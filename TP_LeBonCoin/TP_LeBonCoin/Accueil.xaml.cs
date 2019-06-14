using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TP_LeBonCoin.DAL;

namespace TP_LeBonCoin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Accueil : ContentPage
	{
		public Accueil ()
		{
			InitializeComponent ();
           
        }
        async void ButtonAnnonces(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MesAnnonce());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            annonces.ItemsSource = await App.Database.SelectAnnonces();
        }
    }
}