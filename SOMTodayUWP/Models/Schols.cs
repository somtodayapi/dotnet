using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP.Models
{
    public class Instellingen
    {

        [JsonProperty("naam")]
        public string naam { get; set; }

        [JsonProperty("plaats")]
        public string plaats { get; set; }

        [JsonProperty("uuid")]
        public string uuid { get; set; }
    }

    public class Schols
    {
        [JsonProperty("instellingen")]
        public IList<Instellingen> instellingen { get; set; }
    }
}