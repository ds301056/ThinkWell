using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadingPage : ContentPage {
		public LoadingPage() {
			InitializeComponent();
			this.BindingContext = new LoadingViewModel();

			Device.StartTimer(TimeSpan.FromSeconds(3), () =>
			{
				// Navigate to the DailyPage
				AppShell.Current.GoToAsync("//DailyPage");

				// Return false to stop the timer
				return false;
			});
		}

		protected override async void OnAppearing() {
			base.OnAppearing();
			if (BindingContext is LoadingViewModel viewModel) {
				await viewModel.LoadRandomAnimalImageAsync();
			}
		}
	}
}