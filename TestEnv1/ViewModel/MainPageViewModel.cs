using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using TestEnv1.Helper;
using Windows.ApplicationModel.Resources;
using Windows.Globalization;
using Windows.UI.Xaml.Navigation;

namespace TestEnv1.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private string title { get; set; }
        private string grades { get; set; }
        private string hw { get; set; }
        private string sche { get; set; }
        private string home { get; set; }
        private string vakken { get; set; }
       #region  Management Vars
        private string _username;
        private string _password;
        #endregion

        /// <summary>
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="suspensionState"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> suspensionState)
        {
            Home = Resources.CodeResources.GetString("home_str");
            Grade = Resources.CodeResources.GetString("grad_item");
            Huiswerk = Resources.CodeResources.GetString("hw_item");
            Rooster = Resources.CodeResources.GetString("sch_item");
            Vakken = Resources.CodeResources.GetString("vakk");
            #region date
            Title = "Hallo, " + AppClientUtil.Profile.roepnaam + "!"; 
            #endregion

            await Task.CompletedTask;
        }
        #region binable_ars
        public string Username
        {
            get { return _username; }
            set
            {
                Set(ref _username, value);        
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                Set(ref _password, value);
            }
        }
        #endregion
        /// <summary>
        ///     Save state before navigating
        /// </summary>
        /// <param name="suspensionState"></param>
        /// <param name="suspending"></param>
        /// <returns></returns>
        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(Username)] = Username;
                suspensionState[nameof(Password)] = Password;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        private bool isLoggedin()
        {
            bool bool1 = false;
            return bool1;
        }

        #region strings
        public string Title
        {

            get { return title; }
            set
            {
                title = value;
               
            }
        }
        public string Home
        {
            get { return home; }
            set
            {
                home = value;
            }
        }
        public string Grade
        {

            get { return grades; }
            set
            {
                grades = value;
            }
        }
        public string Huiswerk
        {

            get { return hw; }
            set
            {
                hw = value;
            }
        }
        public string Rooster
        {

            get { return sche; }
            set
            {
                sche = value;
            }
        }
        public string Vakken
        {

            get { return vakken; }
            set
            {
                vakken = value;
          
            }
        }



        #endregion
    }
}
