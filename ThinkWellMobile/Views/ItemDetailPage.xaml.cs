using System.ComponentModel;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;

namespace ThinkWellMobile.Views {
	public partial class ItemDetailPage : ContentPage {
		public ItemDetailPage() {
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}