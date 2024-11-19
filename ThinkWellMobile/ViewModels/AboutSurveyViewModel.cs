using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class AboutSurveyViewModel : BaseViewModel {
		public AboutSurveyViewModel() {
			GoBackCommand = new Command(async () => await Shell.Current.GoToAsync("//DailyPage"));
		}

		// Define a command for the "Go Back" button
		public ICommand GoBackCommand { get; }
	}
}