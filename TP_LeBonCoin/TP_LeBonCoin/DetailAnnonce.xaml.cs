using Plugin.Messaging;
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
	public partial class DetailAnnonce : ContentPage
	{
		public DetailAnnonce ()
		{
			InitializeComponent ();
		}

        void CallNumber(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;
            string number = this.tel.Text;
            call.MakePhoneCall(number);
        }
    }
}