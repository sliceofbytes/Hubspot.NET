namespace HubSpot.NET.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class InputFieldDependency
    {

        [DataMember(Name = "dependencyType", IsRequired = true, EmitDefaultValue = false)]

        public string DependencyType { get; set; }



        [DataMember(Name = "dependentFieldNames", IsRequired = true, EmitDefaultValue = false)]

        public List<string> DependentFieldNames { get; set; }


        [DataMember(Name = "controllingFieldName", IsRequired = true, EmitDefaultValue = false)]

        public string ControllingFieldName { get; set; }
    }
}
