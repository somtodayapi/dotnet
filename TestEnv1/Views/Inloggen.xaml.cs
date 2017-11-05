using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestEnv1.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Inloggen : Page
    {
        public Inloggen()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Enabled;
         
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;
            if (text == "Dutch")
            {
    ApplicationLanguages.PrimaryLanguageOverride = "nl";
            Frame.Navigate(this.GetType());
            }
            else
            {
                ApplicationLanguages.PrimaryLanguageOverride = "en";
                Frame.Navigate(this.GetType());
            }
        
        }
    }
}
