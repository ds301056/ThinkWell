using System;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VentDiaryPage : ContentPage {
		public VentDiaryPage() {
			InitializeComponent();
			this.BindingContext = new VentDiaryViewModel();
		}

		private void OnDiaryEntryClicked(object sender, SelectedItemChangedEventArgs e) {
			if (e.SelectedItem is DiaryEntry selectedEntry) {
				((VentDiaryViewModel)BindingContext).OpenDiaryEntryCommand.Execute(selectedEntry);

				// Reset the selected item to clear the selection state
				if (sender is ListView listView) {
					listView.SelectedItem = null;
				}
			}
		}
	}
}
