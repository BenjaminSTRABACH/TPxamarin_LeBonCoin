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
	public partial class DetailAnnonce : ContentPage
	{
		public DetailAnnonce ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //int idAnnonce = int.Parse(Application.Current.Properties["idAnnonce"] as String);
            //annonce.ItemsSource = App.Database.GetAnnonceById(idAnnonce);
            
        }
    }
}