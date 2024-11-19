using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnalyticsPage : ContentPage {
		public AnalyticsPage() {
			InitializeComponent();
			this.BindingContext = new AnalyticsViewModel();
		}
	}
}
