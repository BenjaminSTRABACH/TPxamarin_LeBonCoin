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
    public partial class MesAnnonce : ContentPage
    {
        public MesAnnonce ()
        {
            InitializeComponent();
        }
        async void ButtonCreerAnnonce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreerAnnonce());
        }
    }
}