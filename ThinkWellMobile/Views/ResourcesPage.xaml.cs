using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResourcesPage : ContentPage {
		private ResourcesViewModel viewModel;

		public ResourcesPage() {
			InitializeComponent();
			viewModel = new ResourcesViewModel();
			BindingContext = viewModel;
		}

		protected override async void OnAppearing() {
			base.OnAppearing();

			var location = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default));
			if (location != null) {
				await viewModel.FindNearbyMentalHealthFacilitiesAsync(location.Latitude, location.Longitude);
				FacilityListView.ItemsSource = viewModel.Facilities;
			}
		}
	}
}