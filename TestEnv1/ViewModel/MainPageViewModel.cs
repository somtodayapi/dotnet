using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.Globalization;

namespace TestEnv1.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        ResourceLoader loader = new ResourceLoader("Strings");
        public event PropertyChangedEventHandler PropertyChanged;
        private string title { get; set; }
        private string grades { get; set; }
        private string hw { get; set; }
        private string sche { get; set; }
        private string home { get; set; }
        private string vakken { get; set; }


        public MainPageViewModel()
        {

            Home = loader.GetString("home_str");
            Grade = loader.GetString("grad_item");
            Huiswerk = loader.GetString("hw_item");
            Rooster = loader.GetString("sch_item");
            Vakken = loader.GetString("vakk");

            #region date
            if (DateTime.Now.Hour < 12)
            {
                //Morning
                if (isLoggedin() == true)
                {
                }
                else
                    Title = loader.GetString("goodmor") + ", " + loader.GetString("sign_in_com");           
            }
            else if (DateTime.Now.Hour < 17)
            {
                //Afternoon
                if (isLoggedin() == true)
                {
                }
                else
                    Title = loader.GetString("goodaft") + ", " + loader.GetString("sign_in_com");
            }
            else
            {
                //Evening
                if (isLoggedin() == true)
                {
                }
                else
                    Title = loader.GetString("goodev") + ", " + loader.GetString("sign_in_com");
            }
            #endregion
        }
        private bool isLoggedin()
        {
            bool bool1 = false;
            return bool1;
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region strings
        public string Title
        {

            get { return title; }
            set
            {
                title = value;
                NotifyPropertyChanged("Title");
            }
        }
        public string Home
        {

            get { return home; }
            set
            {
                home = value;
                NotifyPropertyChanged("Home");
            }
        }
        public string Grade
        {

            get { return grades; }
            set
            {
                grades = value;
                NotifyPropertyChanged("Grade");
            }
        }

        public string Huiswerk
        {

            get { return hw; }
            set
            {
                hw = value;
                NotifyPropertyChanged("Huiswerk");
            }
        }
        public string Rooster
        {

            get { return sche; }
            set
            {
                sche = value;
                NotifyPropertyChanged("Rooster");
            }
        }
        public string Vakken
        {

            get { return vakken; }
            set
            {
                vakken = value;
                NotifyPropertyChanged("Vakken");
            }
        }
        #endregion
    }
}
