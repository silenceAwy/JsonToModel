using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToModel
{
    internal class Class1
    {

        [JsonProperty("ASSEMBLY_SEQUENCE")]
        public string ASSEMBLY_SEQUENCE { get; set; }

        [JsonProperty("PRODUCTION_CODE")]
        public string PRODUCTION_CODE { get; set; }

        [JsonProperty("CHASSIS_NUMBER")]
        public string CHASSIS_NUMBER { get; set; }

        [JsonProperty("APPLIED_MODELS")]
        public string APPLIED_MODELS { get; set; }

        [JsonProperty("PROGRAM_NO")]
        public string PROGRAM_NO { get; set; }

        [JsonProperty("PRODUCT_CODE")]
        public string PRODUCT_CODE { get; set; }

        [JsonProperty("BRIDGE")]
        public string BRIDGE { get; set; }

        [JsonProperty("OPTION_LIST")]
        public string OPTION_LIST { get; set; }

        [JsonProperty("REMARK")]
        public string REMARK { get; set; }

        [JsonProperty("OFFLINE_TIME")]
        public string OFFLINE_TIME { get; set; }

        [JsonProperty("ASSEMBLY_TIME")]
        public string ASSEMBLY_TIME { get; set; }


    }
}
