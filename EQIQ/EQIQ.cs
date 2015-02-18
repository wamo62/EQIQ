using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace EQIQ
{
	public class App : Application
	{
		public App ()
		{
			MainPage = GetMainPage ();
		}

		public static Page GetMainPage()
		{            
			return new NavigationPage(new Steps());
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

