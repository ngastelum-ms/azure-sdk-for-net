﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Infrastructure
{
    public class RouterLiveTestBase : RecordedTestBase<RouterTestEnvironment>
    {
        internal ConcurrentBag<Task> _cleanupTasks;
        protected const string Delimeter = "-";

        public RouterLiveTestBase(bool isAsync, RecordedTestMode? mode = null) : base(isAsync, mode)
        {
            _cleanupTasks = new ConcurrentBag<Task>();
            JsonPathSanitizers.Add("$..token");
            JsonPathSanitizers.Add("$..accessToken");
            JsonPathSanitizers.Add("$..functionKey");
            JsonPathSanitizers.Add("$..appKey");
            SanitizedHeaders.Add("x-ms-content-sha256");
        }

        [SetUp]
        public void SetIdPrefix()
        {
            IdPrefix = Recording.GetVariable("id-prefix", $"sdk-{GetSmallGuid()}-");
        }

        [OneTimeTearDown]
        public async Task CleanUp()
        {
            if (Mode != RecordedTestMode.Playback)
            {
                // Cleanup resources only during Live and Record modes
                Parallel.ForEach(_cleanupTasks, t => t.Start());
                await Task.WhenAll(_cleanupTasks);
            }
        }

        protected RouterClient CreateRouterClientWithConnectionString()
        {
            var connectionString = TestEnvironment.LiveTestDynamicConnectionString;
            var client = new RouterClient(connectionString, CreateRouterClientOptionsWithCorrelationVectorLogs());
            var instrumentedRouterClient = InstrumentClient(client);
            return instrumentedRouterClient;
        }

        #region CRUD Helpers

        protected async Task<Response<ClassificationPolicy>> CreateQueueSelectionCPAsync(string? uniqueIdentifier = default)
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();

            var classificationPolicyId = GenerateUniqueId($"{IdPrefix}{uniqueIdentifier}");
            var classificationPolicyName = $"QueueSelection-ClassificationPolicy";
            var createQueueResponse = await CreateQueueAsync(nameof(CreateQueueSelectionCPAsync));
            var queueSelectionRule = new List<QueueSelectorAttachment>()
            {
                new StaticQueueSelector(new QueueSelector("Id", LabelOperator.Equal, createQueueResponse.Value.Id))
            };
            var createClassificationPolicyResponse = await routerClient.CreateClassificationPolicyAsync(
                id: classificationPolicyId,
                new CreateClassificationPolicyOptions()
                {
                    Name = classificationPolicyName,
                    QueueSelectors = queueSelectionRule,
                    FallbackQueueId = createQueueResponse.Value.Id,
                });
            AddForCleanup(new Task(async () => await routerClient.DeleteClassificationPolicyAsync(createClassificationPolicyResponse.Value.Id)));

            return createClassificationPolicyResponse;
        }

        protected async Task<Response<JobQueue>> CreateQueueAsync(string? uniqueIdentifier = default)
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();
            var createDistributionPolicyResponse = await CreateDistributionPolicy(uniqueIdentifier);
            var queueId = GenerateUniqueId($"{IdPrefix}{uniqueIdentifier}");
            var queueName = "DefaultQueue-Sdk-Test" + queueId;
            var queueLabels = new LabelCollection() { ["Label_1"] = "Value_1" };
            var createQueueResponse = await routerClient.CreateQueueAsync(
                queueId,
                createDistributionPolicyResponse.Value.Id,
                new CreateQueueOptions()
                {
                    Name = queueName,
                    Labels = queueLabels
                });

            AssertQueueResponseIsEqual(createQueueResponse, queueId, createDistributionPolicyResponse.Value.Id, queueName, queueLabels);
            AddForCleanup(new Task(async () => await routerClient.DeleteQueueAsync(createQueueResponse.Value.Id)));
            return createQueueResponse;
        }

        protected async Task<Response<DistributionPolicy>> CreateDistributionPolicy(string? uniqueIdentifier = default)
        {
            RouterClient routerClient = CreateRouterClientWithConnectionString();
            var distributionId = GenerateUniqueId($"{IdPrefix}{uniqueIdentifier}");
            var distributionPolicyName = "LongestIdleDistributionPolicy" + distributionId;
            var createDistributionPolicyResponse = await routerClient.CreateDistributionPolicyAsync(
                distributionId,
                30,
                new LongestIdleMode(1, 1),
                new CreateDistributionPolicyOptions()
                {
                    Name = distributionPolicyName,
                });

            Assert.AreEqual(distributionId, createDistributionPolicyResponse.Value.Id);
            Assert.AreEqual(distributionPolicyName, createDistributionPolicyResponse.Value.Name);
            Assert.IsNotNull(createDistributionPolicyResponse.Value.Mode);
            Assert.IsTrue(createDistributionPolicyResponse.Value.Mode.GetType() == typeof(LongestIdleMode));
            AddForCleanup(new Task(async () => await routerClient.DeleteDistributionPolicyAsync(createDistributionPolicyResponse.Value.Id)));
            return createDistributionPolicyResponse;
        }

        #endregion CRUD Helpers

        #region Support assertions

        protected void AssertQueueResponseIsEqual(Response<JobQueue> upsertQueueResponse, string queueId, string distributionPolicyId, string? queueName = default, LabelCollection? queueLabels = default, string? exceptionPolicyId = default)
        {
            var response = upsertQueueResponse.Value;

            Assert.AreEqual(queueId, response.Id);
            Assert.AreEqual(queueName, response.Name);
            Assert.AreEqual(distributionPolicyId, response.DistributionPolicyId);
            if (queueLabels != default)
            {
                var labelsWithID = queueLabels.ToDictionary(k => k.Key, k => k.Value);
                labelsWithID.Add("Id", queueId);
                Assert.AreEqual(labelsWithID, response.Labels);
            }

            if (exceptionPolicyId != default)
            {
                Assert.AreEqual(exceptionPolicyId, response.ExceptionPolicyId);
            }
        }

        protected void AssertRegisteredWorkerIsValid(Response<RouterWorker> routerWorkerResponse, string workerId, IEnumerable<string> queueAssignmentList, int? totalCapacity, LabelCollection? workerLabels = default, Dictionary<string, ChannelConfiguration>? channelConfigList = default)
        {
            var response = routerWorkerResponse.Value;

            Assert.AreEqual(workerId, response.Id);
            Assert.AreEqual(queueAssignmentList.Count(), response.QueueAssignments.Count);
            Assert.AreEqual(totalCapacity, response.TotalCapacity);

            if (workerLabels != default)
            {
                var labelsWithID = workerLabels.ToDictionary(k => k.Key, k => k.Value);
                labelsWithID.Add("Id", workerId);
                Assert.AreEqual(labelsWithID, response.Labels);
            }

            if (channelConfigList != default)
            {
                Assert.AreEqual(channelConfigList.Count, response.ChannelConfigurations.Count);
            }
        }

        protected void AddForCleanup(Task t)
        {
            _cleanupTasks.Add(t);
        }

        #endregion

        #region private functions

        private RouterClientOptions CreateRouterClientOptionsWithCorrelationVectorLogs()
        {
            RouterClientOptions routerClientOptions = new RouterClientOptions();
            routerClientOptions.Diagnostics.LoggedHeaderNames.Add("MS-CV");
            return InstrumentClientOptions(routerClientOptions);
        }

        #endregion

        protected async Task<T> Poll<T>(Func<Task<T>> query, Func<T, bool> untilCondition, TimeSpan timeOut)
        {
            var result = await query();
            if (untilCondition(result))
                return result;

            var timeOutTime = DateTime.Now.Add(timeOut);
            while (DateTime.Now < timeOutTime)
            {
                if (Mode != RecordedTestMode.Playback)
                    await Task.Delay(TimeSpan.FromSeconds(1));
                result = await query();
                if (untilCondition(result))
                    return result;
            }

            return result;
        }

        protected string? IdPrefix { get; set; }

        private static string GetSmallGuid()
        {
            string encoded = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            encoded = encoded.Replace("/", "_").Replace("+", "-");
            return encoded.Substring(0, 22);
        }

        protected string GenerateUniqueId(params string?[] value)
        {
            var result = GenerateSHA256Id(value);
            var underFiftyCharacters = ReduceToFiftyCharactersInternal(result);
            return underFiftyCharacters;
        }

        private string GenerateSHA256Id(params string?[] values)
        {
            var result = string.Join("", values);
            var input = Encoding.UTF8.GetBytes(result);
            var encoded = SHA256.Create().ComputeHash(input);
            var response = BitConverter.ToString(encoded);
            return response;
        }

        private string ReduceToFiftyCharactersInternal(params string?[] value)
        {
            var result = string.Join("", value);
            var underFiftyCharacters = result.Length > 50 ? result.Substring(0, 50) : result;
            return underFiftyCharacters;
        }
    }
}
