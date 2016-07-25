﻿using System;

using Xamarin.Forms;

namespace Exercise2
{
	public class MasterPage : MasterDetailPage
	{
		public MasterPage()
		{
			string[] PageNames = { "---", "----" };
			ContentView menuLabel = new ContentView
			{
				Padding = new Thickness(10, 36, 0, 5),
				Content = new Label
				{
					TextColor = Color.Black,
					Text = "--- Menu ---",
				}
			};


			ListView listView = new ListView
			{
				ItemsSource = PageNames,
				SeparatorVisibility = Xamarin.Forms.SeparatorVisibility.None
			};

			this.Master = new ContentPage
			{
				
				Icon = "side-panel-icon@2x.png",
				Title = "Menu",
				Content = new StackLayout
				{
					Children = { menuLabel, listView }
				},
			};

			listView.ItemTapped += (sender, e) =>
			 {
				 ContentPage gotoPage;
				 switch (e.Item.ToString())
				 {
					 case "---":
						 gotoPage = new MainPage();
						 break;
					 //case "UserSQL":
						// gotoPage = new UserSQL();
						// break;
					 default:
						 gotoPage = new MainPage();
						 break;
				 }
				 Detail = new NavigationPage(gotoPage);

				 ((ListView)sender).SelectedItem = null;
				 this.IsPresented = false;
			 };

			Detail = new NavigationPage(new MainPage());
		}
	}
}


