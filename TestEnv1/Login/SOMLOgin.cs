using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEnv1.Helper;

namespace TestEnv1.Login
{
    public  class SOMLOgin
    {
        
        private string _access_token;
        public string access_token { get; set; }


        public  async Task<oAuthJSON> DoLogin(string uuid, string username, string pass)
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
