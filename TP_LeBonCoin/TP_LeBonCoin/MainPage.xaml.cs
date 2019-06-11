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

            var DAL = AppDatabase.GetInstance();


            this.login.Text = DAL.Login;
            this.mdp.Text = DAL.Mdp;
        }

        async void ButtonConnexion(object sender, EventArgs e)
        {
            if (login.Text == "oui" && mdp.Text == "123456")
            {
                await Navigation.PushAsync(new Test());
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
            var DAL = AppDatabase.GetInstance();
            DAL.Login = login.Text;
        }

        private void Mdp_Completed(Object sender, EventArgs e)
        {
            var DAL = AppDatabase.GetInstance();
            DAL.Mdp = mdp.Text;
        }
    }
}
