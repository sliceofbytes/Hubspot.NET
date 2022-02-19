using System;
using System.Collections.Generic;

using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Hubspot.NET.Model
{


    public partial class IFrameActionBody
    {

        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "width", IsRequired = true, EmitDefaultValue = false)]

        public long Width { get; set; }


        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = false)]
        public long Height { get; set; }


        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public Uri Url { get; set; }

        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = false)]

        public string Label { get; set; }

        [DataMember(Name = "propertyNamesIncluded", IsRequired = false, EmitDefaultValue = false)]

        public List<object> PropertyNamesIncluded { get; set; }
    }
}
