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
	public partial class CreerAnnonce : ContentPage
	{
		public CreerAnnonce ()
		{
			InitializeComponent ();
		}

        async void ButtonCreerAnnonce(object sender, EventArgs e)
        {
            //Ajouter une annonce
            Annonce annonce = new Annonce
            {
                Titre = this.titre.Text,
                Desc = this.desc.Text,
                Prix = decimal.Parse(this.prix.Text),
                Tel = decimal.Parse(this.tel.Text),
                IDCategorie = 1,
                IDUtilisateur = int.Parse(Application.Current.Properties["session"] as String)
            };
            await App.Database.SaveAnnonce(annonce);
            await DisplayAlert("Annonce créée", "Votre annonce à bien été ajoutée.", "Confirmer");
            await Navigation.PopAsync();
        }

    }
}