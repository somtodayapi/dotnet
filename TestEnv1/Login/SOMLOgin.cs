using Newtonsoft.Json;
using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestEnv1.Helper;

namespace TestEnv1.Login
{
    public  class SOMLOgin
    {
        
        private string _access_token;
        public string access_token { get; set; }

        public  async Task<Persoon> GetUserInfo(string apiUrl, string accesToken)
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
            var pers = JsonConvert.DeserializeObject<RootObject>(resp).persoon;
            return pers;
        }

        public  async Task<AccountMeJSON> DoLogin(string uuid, string username, string pass)
        {
             var item =  await SOMTodayUWP.Login.Authorize(uuid, username, pass);
            if (item.loggedin == true)
            {
                access_token = item.access_token;
                SettingsService.Instance.ApiUrl = item.somtoday_api_url;
                SettingsService.Instance.AccessTokenString = item.access_token;
                SettingsService.Instance.Uuid = uuid;
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
