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
	public partial class Accueil : ContentPage
	{
		public Accueil ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            annonces.ItemsSource = await App.Database.SelectAnnonces();
        }

        async void OnAddTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreerAnnonce());
        }

        async void OnSearchTapped(object sender, EventArgs e)
        {
            
        }
    }
}