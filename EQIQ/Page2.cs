using System;

using Xamarin.Forms;

namespace EQIQ
{
	public class Page2 : ContentPage
	{
		public Page2 ()
		{
			Button homeBtn = new Button {
				Text = " 5 Steps "
			};
			homeBtn.Clicked += OnButtonClicked;


			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "This is Page Two!"
					},
					new Label {
						XAlign = TextAlignment.Center,
						Text = "the second page of the app"
					},
					homeBtn
				}
			};
		
		}


		protected void OnButtonClicked(object sender, EventArgs e)
		{
			//Navigation.PopAsync();
			Navigation.PushAsync(new Steps(), false);
		}
	}
}


