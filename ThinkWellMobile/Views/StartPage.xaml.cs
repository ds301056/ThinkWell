using System;
using Xamarin.Forms;

namespace ThinkWellMobile.Views {
	public partial class StartPage : ContentPage {
		public StartPage() {
			InitializeComponent();

			// Hook up the appearing event handler
			this.Appearing += OnAppearing;
		}

		private async void OnAppearing(object sender, EventArgs e) {
			// Run a simple fade-in animation for LogoStackLayout
			// Set initial opacity to 0
			LogoStackLayout.Opacity = 0;
			await LogoStackLayout.FadeTo(1, 2000);
		}
	}
}
