using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TP_LeBonCoin.DAL;

namespace TP_LeBonCoin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            string[] catTab =
                {
                "Console & Jeux Vidéo",
                "Immobilier",
                "Electroménager",
                "Sport",
                "Vehicule"
            };

            foreach (string titre in catTab)
            {
                var cat = await App.Database.GetCategorieByTitre(titre);
                if (cat == null)
                {
                    cat = new Categorie {
                        Titre = titre
                    };
                    await App.Database.SaveCategorie(cat);
                }
            }

        }

        async void ButtonConnexion(object sender, EventArgs e)
        {
            var utilisateur = await App.Database.GetUtilisateurByLogin(this.login.Text);
            if (utilisateur.Login == this.login.Text)
            {
                if(utilisateur.Mdp == this.mdp.Text)
                {
                    Application.Current.Properties["session"] = utilisateur.ID.ToString();
                    wrongId.IsVisible = false;
                    await Navigation.PushAsync(new Accueil());
                } else
                {
                    wrongId.IsVisible = true;
                }
            } else
            {
                wrongId.IsVisible = true;
            }
        }

        async void ButtonInscription(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inscription());   
        }

        async void ButtonBDD(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BDD());
        }
    }
}
