using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_LeBonCoin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BDD : ContentPage
	{
		public BDD ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewUtilisateurs.ItemsSource = await App.Database.SelectUtilisateurs();
            listViewAnnonces.ItemsSource = await App.Database.SelectAnnonces();
        }
    }
}