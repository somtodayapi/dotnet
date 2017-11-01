using Newtonsoft.Json;
using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.Collections.ObjectModel;
using SOMTodayUWP.Models.Grades;

namespace SOMTodayUWP.Grades
{
    /// <summary>
    /// Functions to get grades of the current school year.
    /// </summary>
    public static class GetCurrentGrades
    {

        /// <summary>
        /// Get grades of current school year.
        /// </summary>
        /// <param name="apiURL">Api url which is returned when signing.</param>
        /// <param name="AccesToken">Acces Token which is returned when signing in</param>
        /// <returns>Returns ObservableCollection of IGrouping. String is key(subject) and item is grade. These can be put in a loop. Examples can be found at docs.</returns>
        public static async Task<ObservableCollection<IGrouping<string, Item>>> GetGrades(string apiURL, string AccesToken)
        {
            var obs = new ObservableCollection<IGrouping<string, Item>>();
            string pupilID = await getPupilID(apiURL, AccesToken);

            //Init httpClient
            HttpClient httpClient = new HttpClient();
            //Set headers
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccesToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string loginUrl = apiURL + "/rest/v1/resultaten/huidigVoorLeerling/" + pupilID;
            //Execute function and read
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            //Deserialize
            var items = JsonConvert.DeserializeObject<RootGrades>(resp).Items;

            var ObsvItems = new ObservableCollection<Item>(items.OrderByDescending(i => i.Resultaat));
            var list = ObsvItems.GroupBy(t => t.Vak.Naam);
            foreach (var lit in list)
            {
                obs.Add(lit);
            }
            return obs;
        }

        private static async Task AddData(Item data)
        {
            var id = data.Vak.Naam;
            ToetsCijferVak newGroup = new ToetsCijferVak();


        }
        private static async Task<string> getPupilID(string apiUrl, string accesToken)
        {
            //Init httpClient
            HttpClient httpClient = new HttpClient();
            //Set headers
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accesToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string loginUrl = apiUrl + "/rest/v1/account/me";
            //Execute function and read
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            //Deserialize
            var links = JsonConvert.DeserializeObject<RootObject>(resp).persoon.links[0].id;
            return links.ToString();
        }

    }
}
