using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;
using Windows.Phone.Devices.Notification;
using Windows.System.Display;
using Windows.UI.Core;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static Template10.Common.BootStrapper;
using TestEnv1.Helper;
using System.Diagnostics;
using TestEnv1.Helper.Uti;

namespace TestEnv1
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki
    [Bindable]
    sealed partial class App : BootStrapper
    {

        #region Private Members

        /// <summary>
        ///     Stores the current <see cref="DisplayRequest"/> instance for the app.
        /// </summary>
        private readonly DisplayRequest _displayRequest;

        #endregion

        #region Properties

        /// <summary>
        /// The TileUpdater instance for the app.
        /// </summary>
        public static TileUpdater LiveTileUpdater { get; private set; }
        public object StatusBar { get; private set; }

        #endregion

        #region Constructor

        public App()
        {
            InitializeComponent();

            // ensure unobserved task exceptions (unawaited async methods returning Task or Task<T>) are handled
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;


            // Set this in the instance constructor to prevent the creation of an unnecessary static constructor.
            _displayRequest = new DisplayRequest();

            // Initialize the Live Tile Updater.
            LiveTileUpdater = TileUpdateManager.CreateTileUpdaterForApplication();


        }

        #endregion

        #region Event Handlers


        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            e.SetObserved();
        }

        private async void NetworkInformationOnNetworkStatusChanged(object sender)
        {
            var connectionProfile = NetworkInformation.GetInternetConnectionProfile();
            var tmpNetworkStatus = connectionProfile != null &&
                                  connectionProfile.GetNetworkConnectivityLevel() ==
                                  NetworkConnectivityLevel.InternetAccess;
            await WindowWrapper.Current().Dispatcher.DispatchAsync(() =>
            {
                if (tmpNetworkStatus)
                {
                }
                else
                {
                }
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cijfers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // if (SettingsService.Instance.LiveTileMode == LiveTileModes.Off) return;
            // Using a Switch here because we might handle other changed events in other ways.
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Replace:
                    break;

            }
        }


        #endregion

        #region Application Lifecycle

        /// <summary>
        ///     Disable vibration on suspending
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <param name="prelaunchActivated"></param>
        /// <returns></returns>
        public override Task OnSuspendingAsync(object s, SuspendingEventArgs e, bool prelaunchActivated)
        {
            AppClientUtil.RecentCijfers.CollectionChanged -= Grade_Chang;
            NetworkInformation.NetworkStatusChanged -= NetworkInformationOnNetworkStatusChanged;
     
            return base.OnSuspendingAsync(s, e, prelaunchActivated);
        }

        public override void OnResuming(object s, object e, AppExecutionState previousExecutionState)
        {
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grade_Chang(object sender, NotifyCollectionChangedEventArgs e)
        {
         
            // Using a Switch here because we might handle other changed events in other ways.
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                case NotifyCollectionChangedAction.Remove:
                case NotifyCollectionChangedAction.Replace:           
                    break;
            }
        }
        /// <summary>
        ///     This runs everytime the app is launched, even after suspension, so we use this to initialize stuff
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {

            // Enter into full screen mode
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
            ApplicationView.GetForCurrentView().SetDesiredBoundsMode(ApplicationViewBoundsMode.UseCoreWindow);
            ApplicationView.GetForCurrentView().FullScreenSystemOverlayMode = FullScreenSystemOverlayMode.Standard;
            // Forces the display to stay on while we play
            //_displayRequest.RequestActive();
            WindowWrapper.Current().Window.VisibilityChanged += WindowOnVisibilityChanged;  
            // Check for network status
            NetworkInformation.NetworkStatusChanged += NetworkInformationOnNetworkStatusChanged;
            // Respond to changes in inventory and Pokemon in the immediate viscinity.
            AppClientUtil.RecentCijfers.CollectionChanged += Grade_Chang;
            await Task.CompletedTask;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="startKind"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            try
            {
                AsyncSynchronizationContext.Register();
                Helper.Uti.AsyncSynchronizationContext.Register();
                var currentAccessToken = AppClientUtil.LoadAccessToken();
                if (currentAccessToken == string.Empty)
                {
                var res =  await NavigationService.NavigateAsync(typeof(Views.Inloggen), "test");
                    Debug.WriteLine(res.ToString());
                }
                else
                {
                    await AppClientUtil.InitializeClient();
                    NavigationService.Navigate(typeof(MainPage));
                }

            }
            catch(Exception e1)
            {
                MessageDialog mes = new MessageDialog(e1.Message);
                await mes.ShowAsync();
            }
            await Task.CompletedTask;
        }

        private void WindowOnVisibilityChanged(object sender, VisibilityChangedEventArgs visibilityChangedEventArgs)
        {
            if (!visibilityChangedEventArgs.Visible)
                _displayRequest.RequestRelease();
            else
                _displayRequest.RequestActive();
        }

        #endregion


    }
}