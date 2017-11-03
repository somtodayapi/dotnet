using Newtonsoft.Json;
using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP
{
   public static class GetSchools
    {
        /// <summary>
        /// Returns instellingen as an array. Gives UUID and Name.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Models.Instellingen>> GetSchoolsFcn()
        {
            //Init httpClient
            HttpClient httpClient = new HttpClient();
            //Set headers
            string loginUrl = "https://servers.somtoday.nl/organisaties.json";
            //Execute function and read
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();

            //Deserialize
            var items = JsonConvert.DeserializeObject<List<Schols>>(resp)[0];

            return items.instellingen.ToList();
        }
    }
}
