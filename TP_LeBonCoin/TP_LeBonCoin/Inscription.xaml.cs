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
	public partial class Inscription : ContentPage
	{
		public Inscription ()
		{
			InitializeComponent ();
		}

        async void ButtonInscription(object sender, EventArgs e)
        {
            //Condition
            if (login.Text != null && mdp.Text != null)
            {
                if (mdp.Text.Length == 6)
                {
                    if (mdp.Text == mdpconfirm.Text)
                    {
                        //Inscrire
                        //var utilisateur = (Utilisateur)BindingContext;
                        Utilisateur utilisateur = new Utilisateur
                        {
                            Login = this.login.Text,
                            Nom = this.nom.Text,
                            Prenom = this.prenom.Text,
                            Mdp = this.mdp.Text
                        };
                        await App.Database.SaveUtilisateur(utilisateur);

                        await DisplayAlert("Inscription réussie", "Vous pouvez maintenant vous connecter à votre espace personnel.", "Confirmer");
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        await DisplayAlert("Erreur", "Le code PIN ne correspond pas.", "Confirmer");
                    }
                } else
                {
                    await DisplayAlert("Erreur", "Le code PIN n'est pas valide. Il doit contenir 6 chiffres.", "Confirmer");
                }
                
                
            } else
            {
                await DisplayAlert("Erreur", "Veuillez entrer un identifiant, un nom, un prénom et un code PIN valide.", "Confirmer");
            }
        }
    }
}