using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace ActionApp
{
	public partial class App : Application
	{

		public App ()
		{

			InitializeComponent();

			MainPage = new ActionApp.MainPage();
            MobileCenter.Start("android=bdf57c1c-19b5-4ff2-bde5-0f76ad820da5;" + "uwp={Your UWP App secret here};" +
           "ios={Your iOS App secret here}",
           typeof(Analytics), typeof(Crashes));
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
