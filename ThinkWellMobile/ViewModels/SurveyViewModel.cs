using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class SurveyViewModel : BaseViewModel {
		public ICommand SubmitCommand { get; }

		public SurveyViewModel() {
			SubmitCommand = new Command(OnSubmitClicked);
		}

		private async void OnSubmitClicked() {
			// Navigate to the DashboardPage
			await Shell.Current.GoToAsync($"//DashboardPage");
		}
	}
}
