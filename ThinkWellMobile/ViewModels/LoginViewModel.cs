using System;
using System.Collections.Generic;
using System.Text;
using ThinkWellMobile.Views;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class LoginViewModel : BaseViewModel {
		public Command LoginCommand { get; }

		public LoginViewModel() {
			LoginCommand = new Command(OnLoginClicked);
		}

		private async void OnLoginClicked(object obj) {
			await Shell.Current.GoToAsync($"//LoadingPage");
		}
	}
}
