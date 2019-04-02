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

            var DAL = Data.GetInstance();


            this.login.Text = DAL.login;
            this.mdp.Text = DAL.mdp;
        }

        async void ButtonConnexion(object sender, EventArgs e)
        {
            if (login.Text == "oui" && mdp.Text == "oui")
            {
                await Navigation.PushAsync(new Test());
            }
        }

        async void ButtonInscription(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new Inscription());
            
        }

        private void login_Completed(Object sender, EventArgs e)
        {
            var DAL = Data.GetInstance();
            DAL.login = login.Text;
        }

        private void mdp_Completed(Object sender, EventArgs e)
        {
            var DAL = Data.GetInstance();
            DAL.mdp = mdp.Text;
        }
    }
}
