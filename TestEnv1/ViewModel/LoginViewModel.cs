using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestEnv1.Exceptions;
using TestEnv1.Helper;
using Windows.ApplicationModel.Resources;
using Windows.UI.Popups;
using Windows.UI.Xaml.Navigation;

namespace TestEnv1.ViewModel
{
    class LoginViewModel : Template10.Mvvm.ViewModelBase
    {
      
   
        #region Lifecycle Handlers


        /// <summary>
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="suspensionState"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> suspensionState)
        {
            Title = Resources.CodeResources.GetString("Title");
            Sub = Resources.CodeResources.GetString("Sub");
            Paragraph = Resources.CodeResources.GetString("Paragraph");
            Button_read = Resources.CodeResources.GetString("ReadMore_Button");
            OrLogin = Resources.CodeResources.GetString("OrLog");
            UsernameBox = Resources.CodeResources.GetString("LoginUsernameTextBox");
            PasswordBox = Resources.CodeResources.GetString("LoginPasswordPasswordBox");
            RememberMe = Resources.CodeResources.GetString("RememberMeCheckBox");
            Login_button = Resources.CodeResources.GetString("LoginButton");
            ChooseLang = Resources.CodeResources.GetString("ChooseLang");
            ChooseSchool = Resources.CodeResources.GetString("ChooseSchool");
            try
            {
                var list1 = await SOMTodayUWP.GetSchools.GetSchoolsFcn();
                Schools = new ObservableCollection<Instellingen>(list1);
            }
            catch(Exception e1)
            {
                Debug.WriteLine(e1.Message);
            }

            // Prevent from going back to other pages
            NavigationService.ClearHistory();
            if (suspensionState.Any())
            {
                // Recovering the state
                Username = (string)suspensionState[nameof(Username)];
                Password = (string)suspensionState[nameof(Password)];
            }
            else
            {
                if (!RememberLoginData) return;
                var currentCredentials = SettingsService.Instance.UserCredentials;
                if (currentCredentials == null) return;
                currentCredentials.RetrievePassword();
                Username = currentCredentials.UserName;
                Password = currentCredentials.Password;
            }
            await Task.CompletedTask;
        }
        private Instellingen _SelectedComboboxItem;
        public Instellingen SelectedComboboxItem
        {
            get { return _SelectedComboboxItem; }
            set
            {
                Set(ref _SelectedComboboxItem, value);
            }
        }

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

        public override async Task OnNavigatingFromAsync(Template10.Services.NavigationService.NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        #endregion
       
       
        #region Management Vars



        private string _username;

        private string _uuid;


        private string _password;



        #endregion

        #region Bindable  Vars

        private ObservableCollection<SOMTodayUWP.Models.Instellingen> _schools = new ObservableCollection<SOMTodayUWP.Models.Instellingen>();
        public ObservableCollection<SOMTodayUWP.Models.Instellingen> Schools
        {
            get { return _schools; }
            set
            {
                Set(ref _schools, value);
            }
        }


        public string Username

        {
            get { return _username; }
            set
            {
                Set(ref _username, value);

                DoSOMLogin.RaiseCanExecuteChanged();

            }

        }
        public string UUID

        {
            get { return _uuid; }
            set
            {
                Set(ref _uuid, value);

                DoSOMLogin.RaiseCanExecuteChanged();

            }

        }

        public string Password
        {
            get { return _password; }
            set

            {
               Set(ref _password, value);
               DoSOMLogin.RaiseCanExecuteChanged();
            }
        }

        public bool RememberLoginData
        {
            get { return SettingsService.Instance.RememberLoginData; }
            set { SettingsService.Instance.RememberLoginData = value; }
        }
        #endregion

        #region Bindable Static
        private string _title;
        private string _sub;
        private string _para;
        private string button_read;
        private string _orlogin;
        private string _usernameBox;
        private string _passwordBox;
        private string _remember;
        private string _login_but;
        private string _ChooseLang;
        private string _ChooseSchool;
        public string Title
        {
            get { return _title; }
            set
            {
                Set(ref _title, value);        
           }
        }
        public string Sub
        {
            get { return _sub; }
            set
            {
                Set(ref _sub, value);
            }
        }
        public string Paragraph
        {
            get { return _para; }
            set
            {
                Set(ref _para, value);
            }
        }
        public string Button_read
        {
            get { return button_read; }
            set
            {
                Set(ref button_read, value);
            }
        }
        public string OrLogin
        {
            get { return _orlogin; }
            set
            {
                Set(ref _orlogin, value);
            }
        }
        public string ChooseSchool
        {
            get { return _ChooseSchool; }
            set
            {
                Set(ref _ChooseSchool, value);
            }
        }
        public string UsernameBox
        {
            get { return _usernameBox; }
            set
            {
                Set(ref _usernameBox, value);
            }
        }
        public string PasswordBox
        {
            get { return _passwordBox; }
            set
            {
                Set(ref _passwordBox, value);
            }
        }
        public string RememberMe
        {
            get { return _remember; }
            set
            {
                Set(ref _remember, value);
            }
        }
        public string Login_button
        {
            get { return _login_but; }
            set
            {
                Set(ref _login_but, value);
            }
        }
        public string ChooseLang
        {
            get { return _ChooseLang; }
            set
            {
                Set(ref _ChooseLang, value);
            }
        }


        #endregion




        #region App Logic
        private Template10.Mvvm.DelegateCommand _doSomLog;

        public Template10.Mvvm.DelegateCommand DoSOMLogin => _doSomLog ?? (

            _doSomLog = new Template10.Mvvm.DelegateCommand(async () =>

            {
                await Task.Delay(50);
                try
                {
                    var login = await  AppClientUtil.DoUWLogin(SelectedComboboxItem.uuid, Username, Password);   
                    if (!login)
                    {
                        // Login failed, show a message
                        await new MessageDialog(Resources.CodeResources.GetString("LoginFailedText")).ShowAsync();
                    }
                    else
                    {
                        var vm = new LoginViewModel { NavigationService = this.NavigationService, Dispatcher = this.Dispatcher };
                        var res = await vm.NavigationService.NavigateAsync(typeof(MainPage), "test");
                        Debug.WriteLine(res.ToString());
                    }
                }
                catch (LoginFailedException e)
                {
                    var errorMessage = e.LoginResponse ?? Resources.CodeResources.GetString("LoginFailedText");

                    await new MessageDialog(errorMessage).ShowAsync();
                }
                catch (Exception e)
                {

                    await ExceptionHandler.HandleException(e);
                    Debug.WriteLine(e.Message); 
                    // HockeyClient.Current.TrackEvent(e.Message);
                }

                finally
                {

                }

            }, () => !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))

            );
    }
    #endregion
}
