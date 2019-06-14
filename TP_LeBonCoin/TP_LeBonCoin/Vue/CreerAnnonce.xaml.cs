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

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            cat.ItemsSource = await App.Database.SelectCategories();
        }

        async void ButtonCreerAnnonce(object sender, EventArgs e)
        {
            
            if (this.titre.Text != null && this.desc.Text != null && this.prix != null && this.tel != null && this.cat != null)
            {
                var categorie = this.cat.SelectedItem as Categorie;
                Annonce annonce = new Annonce
                {
                    Titre = this.titre.Text,
                    Desc = this.desc.Text,
                    Prix = float.Parse(this.prix.Text),
                    Tel = (this.tel.Text).ToString(),
                    IDCategorie = categorie.ID,
                    IDUtilisateur = int.Parse(Application.Current.Properties["session"] as String)
                };
                await App.Database.SaveAnnonce(annonce);
                await DisplayAlert("Annonce créée", "Votre annonce à bien été ajoutée.", "Confirmer");
                await Navigation.PopAsync();
            } else
            {
                await DisplayAlert("Erreur", "Veuiller remplir tout les champs pour créer votre annonce.", "Confirmer");
            }
            
        }

    }
}