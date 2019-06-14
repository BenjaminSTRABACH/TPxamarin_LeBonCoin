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

        async void ButtonConnexion(object sender, EventArgs e)
        {
            var utilisateur = await App.Database.GetUtilisateurByLogin(this.login.Text);
            if (utilisateur.Login == this.login.Text)
            {
                if(utilisateur.Mdp == this.mdp.Text)
                {
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
