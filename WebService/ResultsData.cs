namespace WebService

{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ResultsDataSingleNIP
    {
        [JsonProperty("result")]
        public sResult sResult { get; set; }
    }

    public partial class sResult
    {
        [JsonProperty("subject")]
        public sSubject sSubject { get; set; }

        [JsonProperty("requestId")]
        public string sRequestId { get; set; }

        [JsonProperty("requestDateTime")]
        public string sRequestDateTime { get; set; }
    }

    public partial class sSubject
    {
        [JsonProperty("name")]
        public string sName { get; set; }

        [JsonProperty("nip")]
        public string sNip { get; set; }

        [JsonProperty("statusVat")]
        public string sStatusVat { get; set; }

        [JsonProperty("regon")]
        public long sRegon { get; set; }

        [JsonProperty("pesel")]
        public object sPesel { get; set; }

        [JsonProperty("krs")]
        public string sKrs { get; set; }

        [JsonProperty("residenceAddress")]
        public object sResidenceAddress { get; set; }

        [JsonProperty("workingAddress")]
        public string sWorkingAddress { get; set; }

        [JsonProperty("representatives")]
        public object[] sRepresentatives { get; set; }

        [JsonProperty("authorizedClerks")]
        public object[] sAuthorizedClerks { get; set; }

        [JsonProperty("partners")]
        public object[] sPartners { get; set; }

        [JsonProperty("registrationLegalDate")]
        public DateTimeOffset sRegistrationLegalDate { get; set; }

        [JsonProperty("registrationDenialBasis")]
        public object sRegistrationDenialBasis { get; set; }

        [JsonProperty("registrationDenialDate")]
        public object sRegistrationDenialDate { get; set; }

        [JsonProperty("restorationBasis")]
        public object sRestorationBasis { get; set; }

        [JsonProperty("restorationDate")]
        public object sRestorationDate { get; set; }

        [JsonProperty("removalBasis")]
        public object sRemovalBasis { get; set; }

        [JsonProperty("removalDate")]
        public object sRemovalDate { get; set; }

        [JsonProperty("accountNumbers")]
        public string[] sAccountNumbers { get; set; }

        [JsonProperty("hasVirtualAccounts")]
        public bool sHasVirtualAccounts { get; set; }
    }
}
