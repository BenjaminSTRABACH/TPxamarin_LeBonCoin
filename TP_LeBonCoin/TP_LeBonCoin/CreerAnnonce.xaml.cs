using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_LeBonCoin.DAL;
//using TP_LeBonCoin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_LeBonCoin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreerAnnonce : ContentPage
    {
        public CreerAnnonce()
        {
            InitializeComponent();
        }
        async void ButtonCreerAnnonce(object sender, EventArgs e)
        {
            //Condition
            if (Titre.Text != null && Description.Text != null && Prix != null && Telephone != null && Categorie != null)
            {
                Annonce annonce = new Annonce
                {
                    Titre = this.Titre.Text,
                    Desc = this.Description.Text,
                    Prix = this.Prix.Text,
                    Tel = this.Telephone.Text,
                    Categorie = this.Categorie.Text,


                };
                await App.Database.SaveAnnonce(annonce);


                await Navigation.PushAsync(new MesAnnonce());

            }
            else
            {
                await DisplayAlert("Inscription réussie", "", "Confirmer");
            }
        }
    }
}