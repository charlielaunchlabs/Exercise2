using System;
using Exercise2;
using Exercise2.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(MainPage), typeof(CustomPage))]
namespace Exercise2.iOS
{
	public class CustomPage : PageRenderer
	{
		public CustomPage()
		{
			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
			{
				TextColor = UIColor.White
			});
			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(6, 153, 230);
			UINavigationBar.Appearance.TintColor = UIColor.White;
			UINavigationBar.Appearance.BackgroundColor =UIColor.FromRGB(6, 153, 230);
			UINavigationBar.Appearance.ShadowImage = new UIImage();
			UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);


		}
	}
}

