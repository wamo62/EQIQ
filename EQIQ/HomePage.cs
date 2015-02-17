using System;

using Xamarin.Forms;
using System.Reflection;

namespace EQIQ
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Button page2Btn = new Button {
				Text = "Page2"			};
			page2Btn.Clicked += OnButtonClicked;
		
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "This is the Home Page"
					},
					new Label {
						XAlign = TextAlignment.Center,
						Text = "the main page of the app"
					},
					new Image {
						Source = ImageSource.FromResource("EQIQ.mando.jpg"),
						Aspect = Aspect.AspectFit,
						
					},
					page2Btn
				}
			};

			// NOTE: use for debugging, not in released app code!
//			var assembly = typeof(HomePage).GetTypeInfo().Assembly;
//			foreach (var res in assembly.GetManifestResourceNames()) 
//				System.Diagnostics.Debug.WriteLine("found resource: " + res);
		}

		protected void OnButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Page2(), false);
		}
	}
}


