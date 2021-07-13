// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BaselinesOperations.
    /// </summary>
    public static partial class BaselinesOperationsExtensions
    {
            /// <summary>
            /// **Lists the metric baseline values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='metricnames'>
            /// The names of the metrics (comma separated) to retrieve. Special case: If a
            /// metricname itself has a comma in it then use %2 to indicate it. Eg:
            /// 'Metric,Name1' should be **'Metric%2Name1'**
            /// </param>
            /// <param name='metricnamespace'>
            /// Metric namespace to query metric definitions for.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='aggregation'>
            /// The list of aggregation types (comma separated) to retrieve.
            /// </param>
            /// <param name='sensitivities'>
            /// The list of sensitivities (comma separated) to retrieve.
            /// </param>
            /// <param name='filter'>
            /// The **$filter** is used to reduce the set of metric data returned. Example:
            /// Metric contains metadata A, B and C. - Return all time series of C where A
            /// = a1 and B = b1 or b2 **$filter=A eq 'a1' and B eq 'b1' or B eq 'b2' and C
            /// eq '*'** - Invalid variant: **$filter=A eq 'a1' and B eq 'b1' and C eq '*'
            /// or B = 'b2'** This is invalid because the logical or operator cannot
            /// separate two different metadata names. - Return all time series where A =
            /// a1, B = b1 and C = c1: **$filter=A eq 'a1' and B eq 'b1' and C eq 'c1'** -
            /// Return all time series where A = a1 **$filter=A eq 'a1' and B eq '*' and C
            /// eq '*'**. Special case: When dimension name or dimension value uses round
            /// brackets. Eg: When dimension name is **dim (test) 1** Instead of using
            /// $filter= "dim (test) 1 eq '*' " use **$filter= "dim %2528test%2529 1 eq '*'
            /// "** When dimension name is **dim (test) 3** and dimension value is **dim3
            /// (test) val** Instead of using $filter= "dim (test) 3 eq 'dim3 (test) val' "
            /// use **$filter= "dim %2528test%2529 3 eq 'dim3 %2528test%2529 val' "**
            /// </param>
            /// <param name='resultType'>
            /// Allows retrieving only metadata of the baseline. On data request all
            /// information is retrieved. Possible values include: 'Data', 'Metadata'
            /// </param>
            public static IEnumerable<SingleMetricBaseline> List(this IBaselinesOperations operations, string resourceUri, string metricnames = default(string), string metricnamespace = default(string), string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string aggregation = default(string), string sensitivities = default(string), string filter = default(string), ResultType? resultType = default(ResultType?))
            {
                return operations.ListAsync(resourceUri, metricnames, metricnamespace, timespan, interval, aggregation, sensitivities, filter, resultType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// **Lists the metric baseline values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='metricnames'>
            /// The names of the metrics (comma separated) to retrieve. Special case: If a
            /// metricname itself has a comma in it then use %2 to indicate it. Eg:
            /// 'Metric,Name1' should be **'Metric%2Name1'**
            /// </param>
            /// <param name='metricnamespace'>
            /// Metric namespace to query metric definitions for.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='aggregation'>
            /// The list of aggregation types (comma separated) to retrieve.
            /// </param>
            /// <param name='sensitivities'>
            /// The list of sensitivities (comma separated) to retrieve.
            /// </param>
            /// <param name='filter'>
            /// The **$filter** is used to reduce the set of metric data returned. Example:
            /// Metric contains metadata A, B and C. - Return all time series of C where A
            /// = a1 and B = b1 or b2 **$filter=A eq 'a1' and B eq 'b1' or B eq 'b2' and C
            /// eq '*'** - Invalid variant: **$filter=A eq 'a1' and B eq 'b1' and C eq '*'
            /// or B = 'b2'** This is invalid because the logical or operator cannot
            /// separate two different metadata names. - Return all time series where A =
            /// a1, B = b1 and C = c1: **$filter=A eq 'a1' and B eq 'b1' and C eq 'c1'** -
            /// Return all time series where A = a1 **$filter=A eq 'a1' and B eq '*' and C
            /// eq '*'**. Special case: When dimension name or dimension value uses round
            /// brackets. Eg: When dimension name is **dim (test) 1** Instead of using
            /// $filter= "dim (test) 1 eq '*' " use **$filter= "dim %2528test%2529 1 eq '*'
            /// "** When dimension name is **dim (test) 3** and dimension value is **dim3
            /// (test) val** Instead of using $filter= "dim (test) 3 eq 'dim3 (test) val' "
            /// use **$filter= "dim %2528test%2529 3 eq 'dim3 %2528test%2529 val' "**
            /// </param>
            /// <param name='resultType'>
            /// Allows retrieving only metadata of the baseline. On data request all
            /// information is retrieved. Possible values include: 'Data', 'Metadata'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<SingleMetricBaseline>> ListAsync(this IBaselinesOperations operations, string resourceUri, string metricnames = default(string), string metricnamespace = default(string), string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string aggregation = default(string), string sensitivities = default(string), string filter = default(string), ResultType? resultType = default(ResultType?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceUri, metricnames, metricnamespace, timespan, interval, aggregation, sensitivities, filter, resultType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
