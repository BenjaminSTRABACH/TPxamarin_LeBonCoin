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
	public partial class MesAnnonces : ContentPage
	{
		public MesAnnonces ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            annonces.ItemsSource = await App.Database.SelectAnnoncesByIdUtilisateur();
        }

        async void ButtonCreerAnnonce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreerAnnonce());
        }
    }
}