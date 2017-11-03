using Newtonsoft.Json;
using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Utils;
using TestEnv1.Exceptions;
using Windows.Security.Credentials;
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
        private static oAuthJSON _client;
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
        /// Loads current AccessToken
        /// </summary>
        /// <returns></returns>
        public static String LoadAccessToken()

        {

            var tokenString = SettingsService.Instance.AccessTokenString;

            return tokenString == null ? null : SettingsService.Instance.AccessTokenString;

        }

        /// <summary>
        ///     Sets things up if we didn't come from the login page
        /// </summary>
        /// <returns></returns>
        public static async Task InitializeClient()
        {
            var credentials = SettingsService.Instance.UserCredentials;
            if (credentials != null)
            {


                credentials.RetrievePassword();
                _clientSettings = new Settings
                {
                    Username = credentials.UserName,
                    Password = credentials.Password,
                };
            }

         
            try
            {
                await _client.DoLogin();
            }
            catch (Exception e)
            {
                if (e is AccessTokenExpiredException)
                {
                    Debug.WriteLine("AccessTokenExpired Exception caught");
                    _client.access_token = "0";
                    await _client.DoLogin();
                }
                else
                {
                    await new MessageDialog(e.Message).ShowAsync();
                }
            }
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
            await _client.DoLogin();
            // Update current token even if it's null and clear the token for the other identity provide
            SaveAccessToken();
            // Update other data if login worked
            if (_client.access_token == null) return false;
            SettingsService.Instance.UserCredentials =
                new PasswordCredential(nameof(SettingsService.Instance.UserCredentials), username, password);
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