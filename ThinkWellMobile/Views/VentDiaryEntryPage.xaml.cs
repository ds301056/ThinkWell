using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VentDiaryEntryPage : ContentPage {
		public VentDiaryEntryPage() {
			InitializeComponent();
		}

		public VentDiaryEntryPage(VentDiaryEntryViewModel viewModel) : this() {
			BindingContext = viewModel;
		}

		protected override void OnAppearing() {
			base.OnAppearing();

			if (BindingContext is VentDiaryEntryViewModel viewModel) {
				viewModel.OnAppearing();
			}
		}
	}
}