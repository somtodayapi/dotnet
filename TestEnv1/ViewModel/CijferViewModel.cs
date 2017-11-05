using SOMTodayUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace TestEnv1.ViewModel
{
    public class CijferViewModel : INotifyPropertyChanged
    {
        ResourceLoader loader = new ResourceLoader("Strings");
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Model.CijferGem> cijfers = new ObservableCollection<Model.CijferGem>();

        const string api_url = "https://merewa-api.somtoday.nl";
        const string access_token = "eyJ4NXQjUzI1NiI6ImxZZ2VJNnNQMDY1Um1QTlloZ1dZcmNYcElTNWpidEM5X3V3Z0p0WV8xQVkiLCJraWQiOiJpcmlkaXVtaWRwLTYyNTQ5NDg3Mjc1MzI2NTQwNTcxNDc0NDAzNzAyMzE3NDQ4NTU3IiwiYWxnIjoiUlMyNTYifQ.eyJhdWQiOiJENTBFMEMwNi0zMkQxLTRCNDEtQTEzNy1BOUE4NTBDODkyQzIiLCJzdWIiOiI5NjAyMjJiZi04MzZiLTRmNDMtYWEwYy02NzI0M2NhYjJkNTBcXDM1ZWI3YzNhLWVkMDItNDQ4Mi1iNjE3LTVlYzA0MDBmMWZiMyIsIm5iZiI6MTUwOTU4MjA5MywiYWF0IjoxNTA5NTgyMDkzLCJhbXIiOiJwd2QiLCJzY29wZSI6WyJvcGVuaWQiXSwiaXNzIjoiaHR0cHM6XC9cL3NvbXRvZGF5Lm5sIiwidHlwZSI6ImFjY2VzcyIsImV4cCI6MTUwOTU4NTY5MywiaWF0IjoxNTA5NTgyMDkzLCJqdGkiOiIyZjRlN2M4OS0wNDE3LTQ4MjYtYjhhNC0yMjFlYzMxOTMzNjkifQ.WTWocSzaDjS0unrCnV69FX2Jj1-t_vNB3rtFys4-OE5MpCZkVTwBs_x5omyepUKckwMdDkHvO16tyL5lvB8-S5sMWm6KTm0_NDYkNHRxVwpLUEXnP1DhAChW5er8yi57IeDzCFGgw2Q0Q-sTNHGKDc3KZ5TnC9pRhYAIhlxuGLeS4329ut8TvR8rGSr2qYJ3SgbKztyOaEwkpIvEwTBzg-I41QA6AxtabpGodmPy8ukrT294Y-chLUdLm_CfYw3wqECirVWKK1QgWEbpLKnIc5othR_PWCAKIvfQ1v4zX9fwTu-9DslBffhfE5kP-CdNnXYtUNrWDiZW9_VwUBipig";

  
        public CijferViewModel()
        {
            Cijfers.Clear();
            executeshit();

        }
        public async void executeshit()
        {
         //   var ret = await SOMTodayUWP.Grades.GetCurrentGrades.GetGrades(api_url, access_token);

         /*   foreach (var item1 in ret)
            {
                List<Item> newList = item1.ToList();

                foreach (var item in newList)
                {
                    if (item.PurpleType == "RapportGemiddeldeKolom")
                    {
                        if (item.Periode == 2)
                        {
                            var cf = new Model.CijferGem();
                            cf.Vaknaam = item.Vak.Naam.ToString();
                            var ObsvItems = new ObservableCollection<Item>(newList.OrderByDescending(i => i.DatumInvoer));
                            cf.Laatste_Cijfer = "Laatste cijfer: " +  ObsvItems[0].Resultaat;
                            cf.Gem = item.Resultaat;
                            Cijfers.Add(cf);
                        }
                    }
                }

            }*/
        }
    
        public ObservableCollection<Model.CijferGem> Cijfers
        {
            get { return cijfers; }
            set
            {
                cijfers = value;

            }
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}