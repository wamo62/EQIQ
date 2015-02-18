using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EQIQ
{
	public partial class Steps : ContentPage
	{
		public Steps ()
		{
			InitializeComponent ();
		}

		void OnStep1Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HomePage(), false);
		}

		void OnStep2Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HomePage(), false);
		}

		void OnStep3Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HomePage(), false);
		}

		void OnStep4Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HomePage(), false);
		}

		void OnStep5Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new HomePage(), false);
		}
	}
}

