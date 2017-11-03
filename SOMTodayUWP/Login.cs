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
using Windows.Networking.Connectivity;

namespace SOMTodayUWP
{
    /// <summary>
    /// Functions to authorize account to use endpoints
    /// </summary>
    public static class Login
    {
        const string ServerUrl = "https://productie.somtoday.nl/oauth2/token"; //SOM URL

        /// <summary>
        /// Check for any internet connection.
        /// </summary>
        /// <returns>Boolean(true/false)</returns>
        public static bool IsInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            bool internet = connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            return internet;
        }

        /// <summary>
        /// Authorize account and returns JSON including access_token
        /// refresh_token, api url, scope, id_token and the expiration date. The json is returned in fields.
        /// </summary>
        /// <param name="GUID">GUID is an id that's linked to your school. This GUID can be found at https://servers.somtoday.nl/organisaties.json</param>
        /// <param name="username">Username used to login into SOMToday</param>
        /// <param name="password">Password used to login into SOMToday</param>
        public static async Task<oAuthJSON> Authorize(string GUID, string username, string password)
        {
            oAuthJSON resultMod = new oAuthJSON();

            //First check if internet connection is available before doing anything at all
            if (IsInternet())
            {
                try
                {
                    //Encode postdata to American Standard Code for Information Interchange(ASCII).
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string postData = "?username=" + GUID + @"\" + username + "&password=" + password + "&scope=openid&grant_type=password";
                    byte[] data = encoding.GetBytes(postData);
                    //Init webrequest to POST login information and return JSON data.
                    WebRequest request = WebRequest.Create(ServerUrl + postData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.Headers["ContentLength"] = data.Length.ToString();
                    request.Headers["Authorization"] = String.Format("Basic {0}", "RDUwRTBDMDYtMzJEMS00QjQxLUExMzctQTlBODUwQzg5MkMyOnZEZFdkS3dQTmFQQ3loQ0RoYUNuTmV5ZHlMeFNHTkpY");
                    using (Stream stream = await request.GetRequestStreamAsync())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                    //Execute WebRequest and return Response.
                    using (WebResponse response = await request.GetResponseAsync())
                    {
                        //Read response
                        using (Stream stream = response.GetResponseStream())
                        {
                            using (StreamReader sr = new StreamReader(stream))
                            {
                                string jso = await sr.ReadToEndAsync();
                                //Deserialize JSON and put in list for api USERS to use easily.
                                resultMod = JsonConvert.DeserializeObject<oAuthJSON>((jso));
                                resultMod.loggedin = true;
                            }
                        }
                    }
                }
                catch (Exception e1)
                {
                    Debug.WriteLine(e1);
                }
            }
            else
            {
            }
            return resultMod;
        }        
    }
}