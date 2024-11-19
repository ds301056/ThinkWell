using System;
using System.Collections.Generic;
using ThinkWellMobile.ViewModels;
using ThinkWellMobile.Views;
using Xamarin.Forms;

namespace ThinkWellMobile {
	public partial class AppShell : Xamarin.Forms.Shell {
		public AppShell() {
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e) {
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
