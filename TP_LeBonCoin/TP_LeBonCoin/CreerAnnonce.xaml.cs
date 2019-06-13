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
        }

    }
}