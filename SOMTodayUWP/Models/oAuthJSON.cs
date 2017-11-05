using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP.Models
{
    public  class oAuthJSON
    {
        [JsonProperty("access_token")]
        public string access_token { get; set; }

        [JsonProperty("refresh_token")]
        public string refresh_token { get; set; }

        [JsonProperty("somtoday_api_url")]
        public string somtoday_api_url { get; set; }

        [JsonProperty("scope")]
        public string scope { get; set; }

        [JsonProperty("somtoday_tenant")]
        public string somtoday_tenant { get; set; }

        [JsonProperty("id_token")]
        public string id_token { get; set; }

        [JsonProperty("token_type")]
        public string token_type { get; set; }

        [JsonProperty("expires_in")]
        public int expires_in { get; set; }

        public bool loggedin { get; set; }
    }
}
