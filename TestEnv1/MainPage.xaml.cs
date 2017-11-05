using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestEnv1.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestEnv1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel viewModel;
        public MainPage()
        {
           
            ApplicationLanguages.PrimaryLanguageOverride = "nl";
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;

            viewModel = new MainPageViewModel();

        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
          
            // you can also add items in code behind
            NavView.MenuItems.Add(new NavigationViewItemSeparator());
            NavView.MenuItems.Add(new NavigationViewItem()
            { Content = "Vakken", Icon = new SymbolIcon(Symbol.Folder), Tag = "content" });

            // set the initial SelectedItem 
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "home")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
           
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(Views.Home));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "Home":
                        ContentFrame.Navigate(typeof(Views.Home));
                        break;

                    case "cijfer":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "huiswerk":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "rooster":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "My content":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;
                }
            }
        }

   

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(Views.Cijfer));
            }
            else
            {

                NavigationViewItem item = args.SelectedItem as NavigationViewItem;

                switch (item.Tag)
                {
                    case "home":
                        ContentFrame.Navigate(typeof(Views.Home));
                        break;

                    case "huiswerk":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "cijfers":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "music":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;

                    case "content":
                        ContentFrame.Navigate(typeof(Views.Cijfer));
                        break;
                }
            }
        }
    }
}
