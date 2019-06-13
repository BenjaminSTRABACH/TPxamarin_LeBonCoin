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
            listView.ItemsSource = await App.Database.SelectUtilisateurs();
        }

        async void ButtonConnexion(object sender, EventArgs e)
        {
            var utilisateur = await App.Database.GetUtilisateurByLogin(this.login.Text);
            if (utilisateur != null)
            {
                if(utilisateur.Mdp == this.mdp.Text)
                {
                    await Navigation.PushAsync(new Test());
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

        private void Login_Completed(Object sender, EventArgs e)
        {
            
        }

        private void Mdp_Completed(Object sender, EventArgs e)
        {
            
        }
    }
}
