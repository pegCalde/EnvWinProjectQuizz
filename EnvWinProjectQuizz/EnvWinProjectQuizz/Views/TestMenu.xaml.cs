﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnvWinProjectQuizz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestMenu : MasterDetailPage
    {
        /* Nouvel item = Page maitre/detail, ca crée 4 fichiers. 
           On peut supprimer Detail.xaml, Master.xaml et MenuItem.cs */

        List<MenuItems> MenuItems;
        public TestMenu()
        {
            InitializeComponent();
            MenuItems = new List<MenuItems>();

            MenuItems.Add(new MenuItems { OptionName = "TestFrancais" });
            MenuItems.Add(new MenuItems { OptionName = "TestMaths" });
            MenuItems.Add(new MenuItems { OptionName = "TestHistoire" });

            navigationList.ItemsSource = MenuItems;
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.OptionName)
                {
                    case "TestPage1Menu":
                        {
                            Detail = new NavigationPage(new TestFrancais());
                            IsPresented = false;
                        }
                        break;
                    case "TestPage2Menu":
                        {
                            Detail = new NavigationPage(new TestMaths());
                            IsPresented = false;
                        }
                        break;
                    case "TestPage3Menu":
                        {
                            Detail = new NavigationPage(new TestHistoire());
                            IsPresented = false;
                        }
                        break;
                    case "Logout":
                        {

                        }
                        break;
                }
            } catch(Exception exception)
            {

            }
        }
    }

    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}