using System;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DashboardPage : ContentPage {
		public DashboardPage() {
			InitializeComponent();
			this.BindingContext = new DashboardViewModel();
		}
	}
}