using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Divises.CLASES
{
    public class ClDivisas
    {
        public string Codi { get; set; }

        [JsonProperty("name")]
        public string Nom { get; set; }


        public string NomComplet => $"{Codi} - {Nom}";

        public override string ToString()
        {
            return NomComplet;
        }
    }
}
