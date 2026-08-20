using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Divises.CLASES
{
    public class RatesDBData
    {
        [JsonProperty("date")]
        public string Data { get; set; }

        [JsonProperty("from")]
        public string DivisaOrigen { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, double> Taxes { get; set; }
    }

    public class ResultatRatesDB
    {
        [JsonProperty("data")]
        public RatesDBData Dades { get; set; }
    }
}
