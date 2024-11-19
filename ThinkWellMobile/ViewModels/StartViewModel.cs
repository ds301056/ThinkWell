using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class StartViewModel : BaseViewModel {
		public StartViewModel() {
			Title = "ThinkWell";
			NavigateToSignUpPageCommand = new Command(async () => await Shell.Current.GoToAsync("//SignupPage"));
		}

		public ICommand NavigateToSignUpPageCommand { get; }
	}
}