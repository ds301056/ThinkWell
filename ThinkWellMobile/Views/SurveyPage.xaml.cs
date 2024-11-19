using System;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveyPage : ContentPage {
		public SurveyPage() {
			InitializeComponent();
			this.BindingContext = new SurveyViewModel();
		}

		//private void OnSubmitClicked(object sender, EventArgs e) {
		//	if (BindingContext is SurveyViewModel viewModel) {
		//		// Get selected answers and process them
		//		int question1Answer = Question1Options.SelectedIndex;
		//		int question2Answer = Question2Options.SelectedIndex;
		//		int question3Answer = Question3Options.SelectedIndex;
		//		int question4Answer = Question4Options.SelectedIndex;
		//		int question5Answer = Question5Options.SelectedIndex;

		//		// You can process the answers here, e.g., send them to a server or save locally
		//		// For simplicity, I'll just display them in an alert
		//		string results = $"Question 1: {question1Answer}\nQuestion 2: {question2Answer}\nQuestion 3: {question3Answer}\nQuestion 4: {question4Answer}\nQuestion 5: {question5Answer}";

		//		DisplayAlert("Survey Results", results, "OK");
		//	}
		//}
	}
}
