using System.Collections.Generic;
using Xamarin.Forms;

namespace EnvWinProjectQuizz
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

        }
       private void OnListViewSelected(object sender, SelectedItemChangedEventArgs e)
       {
            Eleve selectedItem = e.SelectedItem as Eleve;
       }

       private void OnViewItemTrapped(object sender, ItemTappedEventArgs e)
       {
            Eleve tappedItem = e.Item as Eleve;
       }
    }
}
