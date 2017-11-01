using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestEnv
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var resp = await SOMTodayUWP.Login.Authorize("960222bf-836b-4f43-aa0c-67243cab2d50", "119371@mymerewade.nl", "christos,2002");
            Debug.WriteLine(resp.somtoday_api_url);

            var ret = await SOMTodayUWP.Grades.GetCurrentGrades.GetGrades(resp.somtoday_api_url, resp.access_token);

            foreach (var item1 in ret)

            {

                List<Item> newList = item1.ToList();

                foreach (var item in newList)

                {

                    Debug.WriteLine(item1.Key.ToString() + " : " + item.Resultaat + " = " + item.Omschrijving + " VOOR: " + item.PurpleType + " PERIODE: " + item.Periode);

                }

            }

        }
    }
}
