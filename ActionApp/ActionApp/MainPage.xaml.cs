using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ActionApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
         void hentetfar(object sender, EventArgs args)
        {
            var smsMessenger = CrossMessaging.Current.SmsMessenger;
            if (smsMessenger.CanSendSms)
                smsMessenger.SendSms("+4530790744", "Well hello there from Xam.Messaging.Plugin");


        }
         void hentetmor(object sender, EventArgs args)
        {
          
        }
         void hjemnufar(object sender, EventArgs args)
        {

        }
         void hjemnumor(object sender, EventArgs args)
        {

        }
         void ringefar(object sender, EventArgs args)
        {

        }
         void ringemor(object sender, EventArgs args)
        {

        }
        
    }
}
