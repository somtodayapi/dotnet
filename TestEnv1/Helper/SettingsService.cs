using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.SettingsService;
using Windows.Security.Credentials;

namespace TestEnv1.Helper
{
    public class SettingsService : BindableBase

    {

        #region Singleton

        private readonly static Lazy<SettingsService> _instance = new Lazy<SettingsService>(() => new SettingsService());

        public static SettingsService Instance { get { return _instance.Value; } }

        private SettingsService()

        {

        }

        #endregion



        #region Storage helper

        private readonly SettingsHelper _helper = new SettingsHelper();

        public void Set<T>(T value, [CallerMemberName] string propertyName = null)
        {
            _helper.Write(propertyName, value);

            RaisePropertyChanged(propertyName);

        }
        public T Get<T>(T defaultValue, [CallerMemberName] string propertyName = null)

        {

            return _helper.Read<T>(propertyName, defaultValue);

        }
        #endregion
        private readonly PasswordVault _passwordVault = new PasswordVault();


        #region Login & Authentication



        public bool RememberLoginData

        {

            get { return Get(false); }

            set { Set(value); }

        }



        public string Uuid

        {

            get { return Get(string.Empty); }

            set { Set(value); }

        }



        public string AccessTokenString

        {

            get

            {

                var credentials = _passwordVault.RetrieveAll();

                var token = credentials.FirstOrDefault(credential => credential.Resource.Equals(nameof(AccessTokenString)));

                if (token == null) return string.Empty;

                token.RetrievePassword();

                return token.Password;

            }

            set

            {

                var credentials = _passwordVault.RetrieveAll();

                var currentToken =

                        credentials.FirstOrDefault(credential => credential.Resource.Equals(nameof(AccessTokenString)));

                if (currentToken != null) _passwordVault.Remove(currentToken);

                if (value == null) return;

                _passwordVault.Add(new PasswordCredential

                {

                    UserName = nameof(AccessTokenString),

                    Password = value,

                    Resource = nameof(AccessTokenString)

                });

            }

        }

        public PasswordCredential UserCredentials

        {

            get

            {

                var credentials = _passwordVault.RetrieveAll();

                return credentials.FirstOrDefault(credential => credential.Resource.Equals(nameof(UserCredentials)));

            }

            set

            {

                var credentials = _passwordVault.RetrieveAll();

                var currentCredential =

                        credentials.FirstOrDefault(credential => credential.Resource.Equals(nameof(UserCredentials)));

                if (currentCredential != null) _passwordVault.Remove(currentCredential);

                if (value == null) return;

                _passwordVault.Add(value);

            }

        }



        #endregion


        #region Dev Stuff

        public bool ShowDebugInfoInErrorMessage

        {

            get

            {

#if DEBUG

                //Default value set to true if DEBUG :)

                return Get(true);

#else

				return Get(false);

#endif

            }

            set

            {

                Set(value);

            }

        }

        #endregion

    }

}