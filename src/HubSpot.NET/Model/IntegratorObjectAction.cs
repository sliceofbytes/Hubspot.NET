namespace HubSpot.NET.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class IntegratorObjectAction
    {

        [DataMember(Name = "type", EmitDefaultValue = false)]

        public string Type { get; set; }


        [DataMember(Name = "httpMethod", EmitDefaultValue = false)]

        public string HttpMethod { get; set; }


        [DataMember(Name = "url", EmitDefaultValue = false)]

        public Uri Url { get; set; }


        [DataMember(Name = "label", EmitDefaultValue = false)]

        public string Label { get; set; }

        [DataMember(Name = "propertyNamesIncluded", EmitDefaultValue = false)]

        public List<string> PropertyNamesIncluded { get; set; }
    }
}
