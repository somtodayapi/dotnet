using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Common;
using TestEnv1.Exceptions;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace TestEnv1.Helper
{
    public static class ExceptionHandler

    {

        public static async Task HandleException(Exception e = null)

        {

            try

            {

                if (e != null && (e.GetType() == typeof(ApiNonRecoverableException)))

                {

                    Debug.WriteLine($"[Relogin] {nameof(ApiNonRecoverableException)} from API handled.");

                    Debug.WriteLine("[Relogin] Successfuly ended.");

                }

                else if (e != null && e.GetType() == (typeof(AccessTokenExpiredException)))

                {

                    await

                        new MessageDialog(Resources.CodeResources.GetString("LoginExpired")).ShowAsync();

                    AppClientUtil.DoLogout();

                    BootStrapper.Current.NavigationService.Navigate(typeof(Views.Inloggen));

                }
    
                else

                {

                    bool showDebug = false;

                    try

                    {

                        //get inside try/catch in case exception comes from settings instance (storage access issue, ...)

                        showDebug = SettingsService.Instance.ShowDebugInfoInErrorMessage;

                    }

                    catch { }



                    string message = Resources.CodeResources.GetString("SomethingWentWrongText");

                    if (showDebug)

                    {

                        message += $"\nException";

                        message += $"\n Message:[{e?.Message}]";

                        message += $"\n InnerMessage:[{e?.InnerException?.Message}]";

                        message += $"\n StackTrace:[{e?.StackTrace}]";

                    }



                    var dialog = new MessageDialog(message);

                    dialog.Commands.Add(new UICommand(Resources.CodeResources.GetString("YesText")) { Id = 0 });

                    dialog.Commands.Add(new UICommand(Resources.CodeResources.GetString("NoText")) { Id = 1 });

                    dialog.DefaultCommandIndex = 0;

                    dialog.CancelCommandIndex = 1;

                    var result = await dialog.ShowAsync();

                    if ((int)result.Id == 0)

                    {
                        AppClientUtil.DoLogout();
                    }

                }

            }

            catch (Exception ex)

            {

              //  HockeyClient.Current.TrackException(ex);

                Application.Current.Exit();

            }

        }

    }

}