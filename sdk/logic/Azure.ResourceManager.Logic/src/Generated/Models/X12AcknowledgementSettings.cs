// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 agreement acknowledgement settings. </summary>
    public partial class X12AcknowledgementSettings
    {
        /// <summary> Initializes a new instance of X12AcknowledgementSettings. </summary>
        /// <param name="needTechnicalAcknowledgement"> The value indicating whether technical acknowledgement is needed. </param>
        /// <param name="batchTechnicalAcknowledgements"> The value indicating whether to batch the technical acknowledgements. </param>
        /// <param name="needFunctionalAcknowledgement"> The value indicating whether functional acknowledgement is needed. </param>
        /// <param name="batchFunctionalAcknowledgements"> The value indicating whether to batch functional acknowledgements. </param>
        /// <param name="needImplementationAcknowledgement"> The value indicating whether implementation acknowledgement is needed. </param>
        /// <param name="batchImplementationAcknowledgements"> The value indicating whether to batch implementation acknowledgements. </param>
        /// <param name="needLoopForValidMessages"> The value indicating whether a loop is needed for valid messages. </param>
        /// <param name="sendSynchronousAcknowledgement"> The value indicating whether to send synchronous acknowledgement. </param>
        /// <param name="acknowledgementControlNumberLowerBound"> The acknowledgement control number lower bound. </param>
        /// <param name="acknowledgementControlNumberUpperBound"> The acknowledgement control number upper bound. </param>
        /// <param name="rolloverAcknowledgementControlNumber"> The value indicating whether to rollover acknowledgement control number. </param>
        public X12AcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgements, bool needFunctionalAcknowledgement, bool batchFunctionalAcknowledgements, bool needImplementationAcknowledgement, bool batchImplementationAcknowledgements, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgements = batchTechnicalAcknowledgements;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            BatchFunctionalAcknowledgements = batchFunctionalAcknowledgements;
            NeedImplementationAcknowledgement = needImplementationAcknowledgement;
            BatchImplementationAcknowledgements = batchImplementationAcknowledgements;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary> Initializes a new instance of X12AcknowledgementSettings. </summary>
        /// <param name="needTechnicalAcknowledgement"> The value indicating whether technical acknowledgement is needed. </param>
        /// <param name="batchTechnicalAcknowledgements"> The value indicating whether to batch the technical acknowledgements. </param>
        /// <param name="needFunctionalAcknowledgement"> The value indicating whether functional acknowledgement is needed. </param>
        /// <param name="functionalAcknowledgementVersion"> The functional acknowledgement version. </param>
        /// <param name="batchFunctionalAcknowledgements"> The value indicating whether to batch functional acknowledgements. </param>
        /// <param name="needImplementationAcknowledgement"> The value indicating whether implementation acknowledgement is needed. </param>
        /// <param name="implementationAcknowledgementVersion"> The implementation acknowledgement version. </param>
        /// <param name="batchImplementationAcknowledgements"> The value indicating whether to batch implementation acknowledgements. </param>
        /// <param name="needLoopForValidMessages"> The value indicating whether a loop is needed for valid messages. </param>
        /// <param name="sendSynchronousAcknowledgement"> The value indicating whether to send synchronous acknowledgement. </param>
        /// <param name="acknowledgementControlNumberPrefix"> The acknowledgement control number prefix. </param>
        /// <param name="acknowledgementControlNumberSuffix"> The acknowledgement control number suffix. </param>
        /// <param name="acknowledgementControlNumberLowerBound"> The acknowledgement control number lower bound. </param>
        /// <param name="acknowledgementControlNumberUpperBound"> The acknowledgement control number upper bound. </param>
        /// <param name="rolloverAcknowledgementControlNumber"> The value indicating whether to rollover acknowledgement control number. </param>
        internal X12AcknowledgementSettings(bool needTechnicalAcknowledgement, bool batchTechnicalAcknowledgements, bool needFunctionalAcknowledgement, string functionalAcknowledgementVersion, bool batchFunctionalAcknowledgements, bool needImplementationAcknowledgement, string implementationAcknowledgementVersion, bool batchImplementationAcknowledgements, bool needLoopForValidMessages, bool sendSynchronousAcknowledgement, string acknowledgementControlNumberPrefix, string acknowledgementControlNumberSuffix, int acknowledgementControlNumberLowerBound, int acknowledgementControlNumberUpperBound, bool rolloverAcknowledgementControlNumber)
        {
            NeedTechnicalAcknowledgement = needTechnicalAcknowledgement;
            BatchTechnicalAcknowledgements = batchTechnicalAcknowledgements;
            NeedFunctionalAcknowledgement = needFunctionalAcknowledgement;
            FunctionalAcknowledgementVersion = functionalAcknowledgementVersion;
            BatchFunctionalAcknowledgements = batchFunctionalAcknowledgements;
            NeedImplementationAcknowledgement = needImplementationAcknowledgement;
            ImplementationAcknowledgementVersion = implementationAcknowledgementVersion;
            BatchImplementationAcknowledgements = batchImplementationAcknowledgements;
            NeedLoopForValidMessages = needLoopForValidMessages;
            SendSynchronousAcknowledgement = sendSynchronousAcknowledgement;
            AcknowledgementControlNumberPrefix = acknowledgementControlNumberPrefix;
            AcknowledgementControlNumberSuffix = acknowledgementControlNumberSuffix;
            AcknowledgementControlNumberLowerBound = acknowledgementControlNumberLowerBound;
            AcknowledgementControlNumberUpperBound = acknowledgementControlNumberUpperBound;
            RolloverAcknowledgementControlNumber = rolloverAcknowledgementControlNumber;
        }

        /// <summary> The value indicating whether technical acknowledgement is needed. </summary>
        public bool NeedTechnicalAcknowledgement { get; set; }
        /// <summary> The value indicating whether to batch the technical acknowledgements. </summary>
        public bool BatchTechnicalAcknowledgements { get; set; }
        /// <summary> The value indicating whether functional acknowledgement is needed. </summary>
        public bool NeedFunctionalAcknowledgement { get; set; }
        /// <summary> The functional acknowledgement version. </summary>
        public string FunctionalAcknowledgementVersion { get; set; }
        /// <summary> The value indicating whether to batch functional acknowledgements. </summary>
        public bool BatchFunctionalAcknowledgements { get; set; }
        /// <summary> The value indicating whether implementation acknowledgement is needed. </summary>
        public bool NeedImplementationAcknowledgement { get; set; }
        /// <summary> The implementation acknowledgement version. </summary>
        public string ImplementationAcknowledgementVersion { get; set; }
        /// <summary> The value indicating whether to batch implementation acknowledgements. </summary>
        public bool BatchImplementationAcknowledgements { get; set; }
        /// <summary> The value indicating whether a loop is needed for valid messages. </summary>
        public bool NeedLoopForValidMessages { get; set; }
        /// <summary> The value indicating whether to send synchronous acknowledgement. </summary>
        public bool SendSynchronousAcknowledgement { get; set; }
        /// <summary> The acknowledgement control number prefix. </summary>
        public string AcknowledgementControlNumberPrefix { get; set; }
        /// <summary> The acknowledgement control number suffix. </summary>
        public string AcknowledgementControlNumberSuffix { get; set; }
        /// <summary> The acknowledgement control number lower bound. </summary>
        public int AcknowledgementControlNumberLowerBound { get; set; }
        /// <summary> The acknowledgement control number upper bound. </summary>
        public int AcknowledgementControlNumberUpperBound { get; set; }
        /// <summary> The value indicating whether to rollover acknowledgement control number. </summary>
        public bool RolloverAcknowledgementControlNumber { get; set; }
    }
}
