using Newtonsoft.Json;
using Q42.WinRT.Data;
using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Template10.Common;
using Template10.Services.NavigationService;
using Template10.Utils;
using TestEnv1.Exceptions;
using TestEnv1.ViewModel;
using Windows.Security.Credentials;
using Windows.Storage;
using Windows.UI.Popups;

namespace TestEnv1.Helper
{
    /// <summary>
    ///     Static class containing game's state and wrapped client methods to update data
    /// </summary>
    public static class AppClientUtil
    {   
        #region Client Vars
        private static ISettings _clientSettings;
        private static Login.SOMLOgin _client = new Login.SOMLOgin();
        public static Persoon Profile { get; private set; }
        #endregion
        #region Collections
        /// <summary>
        ///		Collection of recent cijfers
        /// </summary>
        public static ObservableCollection<ObservableCollection<IGrouping<string, Item>>> RecentCijfers { get; set; } =
           new ObservableCollection<ObservableCollection<IGrouping<string, Item>>>();
        #endregion
        #region Constructor
        static AppClientUtil()
        {          
            RecentCijfers.CollectionChanged += Grade_Changed;
            // TODO: Investigate whether or not this needs to be unsubscribed when the app closes.
        } 
        /// <summary>
        /// When new grades are added to the List
        /// </summary>
        /// <remarks>
        /// This exists because the Grades are List objects. If you don't do this,
        /// the first Grades  are always shown as "new to the list" regardless of if they are
        /// ACTUALLY new.
        /// </remarks>
        public static void Grade_Changed(object sender, NotifyCollectionChangedEventArgs e)

        {

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                // advancedrei: This is a total order-of-operations hack.
                var nearby = RecentCijfers.ToList();

                RecentCijfers.Clear();

               RecentCijfers.AddRange(nearby);

            }
        }
        #endregion
        #region App Logic
        #region Login/Logout
        /// <summary>
        /// Saves the new AccessToken to settings.
        /// </summary>
        private static void SaveAccessToken()
        {
            SettingsService.Instance.AccessTokenString = _client.access_token;
        }

        /// <summary>
        /// Checks if the token is expired
        /// </summary>
        public static async Task<bool> IsExpired(string token, string apiUrl)
        {
            //Init httpClient
            HttpClient httpClient = new HttpClient();
            //Set headers
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string loginUrl = apiUrl + "/rest/v1/account/me";
            //Execute function and read
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            if(resp == null || resp == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Loads current AccessToken
        /// </summary>
        /// <returns></returns>
        public async static Task<String> LoadAccessToken()
        {
            var tokenString = SettingsService.Instance.AccessTokenString;
            if (GetApiUrl() != string.Empty)
            {
                bool isExp = await IsExpired(tokenString, SettingsService.Instance.ApiUrl);
                if (!isExp || tokenString != null)
                {
                    return tokenString;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        private static string GetApiUrl()
        {
            return SettingsService.Instance.ApiUrl;
        }
        /// <summary>
        ///     Sets things up if we didn't come from the login page
        /// </summary>
        /// <returns></returns>
        public static async Task InitializeClient()
        {
            DataCache.Init();
            var credentials = SettingsService.Instance.UserCredentials;
            if (credentials != null)
            {
                var localsettings = ApplicationData.Current.LocalSettings;
                credentials.RetrievePassword();
                _clientSettings = new Settings
                {
                    Username = credentials.UserName,
                    Password = credentials.Password,
                    UUId = localsettings.Values["schoolid"].ToString()
                };
            }
            try
            {
                await _client.DoLogin(SettingsService.Instance.Uuid,SettingsService.Instance.UserCredentials.UserName, SettingsService.Instance.UserCredentials.Password);
               await UpdateProfile();
            }
            catch (Exception e)
            {
                if (e is AccessTokenExpiredException)
                {
                    Debug.WriteLine("AccessTokenExpired Exception caught");
                    _client.access_token = "0";
                    await _client.DoLogin(SettingsService.Instance.Uuid, SettingsService.Instance.UserCredentials.UserName, SettingsService.Instance.UserCredentials.Password);
                    await UpdateProfile();
                }
                else
                {
                    // from inside any window
                    await UpdateProfile();
                    var nav = WindowWrapper.Current().NavigationServices.FirstOrDefault();
                    nav.Navigate(typeof(Views.Inloggen));
                }
            }
        }
        /// <summary>
        ///     Gets user's profile
        /// </summary>
        /// <returns></returns>
        public static async Task UpdateProfile()
        {
          Profile = (await _client.GetUserInfo(SettingsService.Instance.ApiUrl, SettingsService.Instance.AccessTokenString));
        }
        /// <summary>
        /// Handles login
        /// </summary>
        /// <param name="uuid">UUID of school</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public static async Task<bool> DoUWLogin(string uuid, string username, string password)
        {
            _clientSettings = new Settings
            {
                Username = username,
                UUId = uuid,
                Password = password
            };
         
            // Get token
            await _client.DoLogin(uuid, username, password);
            // Update current token even if it's null and clear the token for the other identity provide
            SaveAccessToken();
            // Update other data if login worked
            if (_client.access_token == null) return false;
            SettingsService.Instance.UserCredentials =
                new PasswordCredential(uuid, username, password);
            SettingsService.Instance.Uuid = uuid;
            await UpdateProfile();
            // Return true if login worked, meaning that we have a token
            return true;
        }
        /// <summary>
        ///     Logs the user out by clearing data
        /// </summary>
        public static void DoLogout()
        {
            // Clear stored token
            SettingsService.Instance.AccessTokenString = null;
            if (!SettingsService.Instance.RememberLoginData)
               SettingsService.Instance.UserCredentials = null;
        }
        #endregion
        #endregion
    }

}