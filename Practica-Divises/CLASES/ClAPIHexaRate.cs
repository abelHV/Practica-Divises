using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Divises.CLASES
{
   

    public class HexaRateData
    {
        [JsonProperty("base")]
        public string BaseDivisa { get; set; }

        [JsonProperty("target")]
        public string TargetDivisa { get; set; }

        [JsonProperty("mid")]
        public double Taxa { get; set; } 

        [JsonProperty("unit")]
        public int Unitat { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ResultatHexaRate
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("data")]
        public HexaRateData Dades { get; set; }
    }

}
