using System;

using Xamarin.Forms;

namespace Exercise2
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			
			this.Title = "COUPONS";

			var goTo = new ToolbarItem
			{
				Icon = "search-icon.png",
				Priority = 1,
				Text = "search",
				//Command = new Command(async () => await Navigation.PopModalAsync())
			};
			var saVe = new ToolbarItem
			{
				Icon = "nav-category-icon",
				Priority = 0,
				Text = "box",
				//Command = new Command(async () => await Navigation.PopModalAsync())
			};
			this.ToolbarItems.Add(goTo);
			this.ToolbarItems.Add(saVe);

			ScrollView scroll = new ScrollView();
			scroll.BackgroundColor = Color.FromHex("0699E6");
			scroll.Orientation = ScrollOrientation.Horizontal;
			scroll.HeightRequest = 50;
			var stack = new StackLayout();
			stack.Orientation = StackOrientation.Horizontal;
			stack.HorizontalOptions = LayoutOptions. StartAndExpand;
			stack.Padding = new Thickness(10,10,10,10);
			stack.Spacing = 10;
			stack.Children.Add(new Button {HorizontalOptions=LayoutOptions.Center,BorderColor=Color.White,BorderWidth=1.5, Text = "dsads",TextColor=Color.White,HeightRequest=25,BorderRadius= (int)(double)(25 / 1.4), WidthRequest=80 });
			stack.Children.Add(new Button {HorizontalOptions = LayoutOptions.Center, BorderColor = Color.White,BorderWidth = 1.5, Text = "dsads", TextColor = Color.White, HeightRequest = 25, BorderRadius = (int)(double)(25 / 1.6), WidthRequest = 80 });
			stack.Children.Add(new Button {HorizontalOptions = LayoutOptions.Center, BorderColor = Color.White,BorderWidth = 1.5, Text = "dsads", TextColor = Color.White, HeightRequest = 25, BorderRadius = (int)(double)(25 / 1.6), WidthRequest = 80 });
			stack.Children.Add(new Button {HorizontalOptions = LayoutOptions.Center, BorderColor = Color.White,BorderWidth = 1.5, Text = "dsad", TextColor = Color.White, HeightRequest = 25, BorderRadius = (int)(double)(25 / 1.6), WidthRequest = 80 });
			stack.Children.Add(new Button {HorizontalOptions = LayoutOptions.Center, BorderColor = Color.White, BorderWidth = 1.5, Text = "dsad", TextColor = Color.White, HeightRequest = 25, BorderRadius = (int)(double)(25 / 1.6), WidthRequest = 80 });
			stack.Children.Add(new Button {HorizontalOptions = LayoutOptions.Center, BorderColor = Color.White, BorderWidth = 1.5, Text = "dsad", TextColor = Color.White, HeightRequest = 25, BorderRadius = (int)(double)(25 / 1.6), WidthRequest = 80 });
			scroll.Content = stack;

			StackLayout stack1 = new StackLayout();
			stack1.Padding = new Thickness(10, 10, 0,10);
			stack1.Orientation = StackOrientation.Horizontal;
			stack1.Children.Add(new Image {Source = "coupon-downloads.png" });
			StackLayout stack2 = new StackLayout();
			stack2.BackgroundColor = Color.Black;
			stack2.Spacing = 0.5;
			stack2.Orientation = StackOrientation.Horizontal;
			Label az = new Label { VerticalOptions = LayoutOptions.Center, TextColor = Color.FromRgb(244, 128, 36), FontSize = 10, Text = "A to Z", BackgroundColor = Color.White };
			Label newest =  new Label { VerticalOptions = LayoutOptions.Center, TextColor = Color.FromRgb(244, 128, 36), FontSize = 10, Text = "Newest", BackgroundColor = Color.White };
			stack2.Children.Add(new StackLayout {Padding = new Thickness(10,0,10,0), BackgroundColor = Color.White, VerticalOptions = LayoutOptions.FillAndExpand, Children = { az} });
			stack2.Children.Add(new StackLayout {Padding = new Thickness(10, 0, 10, 0), BackgroundColor = Color.White,VerticalOptions = LayoutOptions.FillAndExpand, Children = { newest} });
			stack1.Children.Add(stack2);

			ScrollView Vscroll = new ScrollView();

			az.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(() => OnLabelClicked()),
			});

			newest.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(() => OnLabelClicked()),
			});



			StackLayout mainStack = new StackLayout();
			mainStack.Spacing = 10;
			mainStack.Orientation = StackOrientation.Vertical;

			for (int i = 1; i < 3; i++)
			{

				StackLayout Vstack1 = new StackLayout()
				{
					Orientation = StackOrientation.Horizontal,
					HeightRequest = 130,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.FromHex("E6E6E6"),
					Children =
				{
					new Image
					{
						HeightRequest = 130,
						WidthRequest = 130,
						BackgroundColor=Color.White,
						Source = "coupon-downloads@3x.png"
					},
					new StackLayout
					{
						Orientation = StackOrientation.Vertical,
						Padding = new Thickness(10, 10, 10, 10),
						Spacing =20,
						Children =
						{
							new StackLayout
							{
								Orientation = StackOrientation.Vertical,
								Children =
								{
									new Label
									{
										TextColor = Color.Aqua,
										FontSize = 15,
										Text = "Adgasd Sdasdasd Adsafasd"
									},
									new Label
									{
										TextColor = Color.Black,
										FontSize = 10,
										Text = "Adgasd Asddds"
									}
								}
							},
							new StackLayout
							{
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions= LayoutOptions.FillAndExpand,
								Spacing=50,
								Children =
								{
									new StackLayout
									{
										Orientation = StackOrientation.Vertical,
										HorizontalOptions=LayoutOptions.Start,
										Children =
										{
											new StackLayout
											{
												Orientation=StackOrientation.Horizontal,
												Children =
												{
													new Image
													{
														Source = "coupon-downloads.png"
													},
													new Label
													{
														TextColor = Color.Black,
														FontSize = 10,
														Text = "Adgas "
													}
												}
											},
											new StackLayout
											{
												Orientation=StackOrientation.Horizontal,
												Children =
												{
													new Image
													{
														Source = "coupon-expiry.png"
													},
													new Label
													{
														TextColor = Color.Black,
														FontSize = 10,
														Text = "Adgas"
													}
												}
											}
										}
									},

										new StackLayout
										{
											HorizontalOptions=LayoutOptions.End,
											Children = 
											{
												new ImageButton() 
											}
										}

								},
							}

						}

					}
				}
				};
				mainStack.Children.Add(Vstack1);
			}

			Vscroll.Content = mainStack;
			Content = new StackLayout
			{
				Children = {scroll,stack1,Vscroll
					
				}
			};
		}

		async void  OnLabelClicked()
		{
			await this.DisplayAlert("dddd","dddd","OK");
		}
}

	public class ImageButton : ContentView
	{
		private const int size = 37;
		public ImageButton()
		{
			Image image = new Image
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Source = ImageSource.FromFile("download_button.png"),
				HeightRequest = size,
				WidthRequest = size
			};
			Button button = new Button
			{
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				BackgroundColor = Color.Transparent,
				HeightRequest = size,
				WidthRequest = size,
				BorderRadius = size / 2 + 1,
				BorderColor = Color.Red,
				BorderWidth = 1
			};
			button.Clicked += delegate
			{
				button.Opacity = .5;
				button.FadeTo(1);
			};
			AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			AbsoluteLayout.SetLayoutFlags(button, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(button, new Rectangle(0, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
			Content = new AbsoluteLayout
			{
				Children = {
					image,
					button
				},
			};
		}
	}
}


