﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                await DisplayAlert("Erreur", "Veuillez entrer un identifiant et un code PIN valide.", "Confirmer");
            }
        }
    }
}