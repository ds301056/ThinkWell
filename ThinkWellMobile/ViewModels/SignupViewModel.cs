using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class SignupViewModel : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		private string username;
		private string password;
		private string email;
		private DateTime birthdate;
		private string gender;
		private string city;
		private string state;
		private string zipcode;

		public string Username {
			get => username;
			set => SetProperty(ref username, value);
		}

		public string Password {
			get => password;
			set => SetProperty(ref password, value);
		}

		public string Email {
			get => email;
			set => SetProperty(ref email, value);
		}

		public DateTime Birthdate {
			get => birthdate;
			set => SetProperty(ref birthdate, value);
		}

		public string Gender {
			get => gender;
			set => SetProperty(ref gender, value);
		}

		public string City {
			get => city;
			set => SetProperty(ref city, value);
		}

		public string State {
			get => state;
			set => SetProperty(ref state, value);
		}

		public string Zipcode {
			get => zipcode;
			set => SetProperty(ref zipcode, value);
		}

		public ObservableCollection<string> Genders { get; } = new ObservableCollection<string>
		{
			"Male",
			"Female",
			"Other"
		};

		private string selectedGender;

		public string SelectedGender {
			get => selectedGender;
			set => SetProperty(ref selectedGender, value);
		}

		public ICommand SignupCommand { get; }

		public SignupViewModel() {
			SignupCommand = new Command(ExecuteSignup);
		}

		private async void ExecuteSignup() {
			//Add actual sign up logic later
			await Shell.Current.GoToAsync($"//LoadingPage");
		}

		protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "") {
			if (EqualityComparer<T>.Default.Equals(backingStore, value))
				return false;

			backingStore = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
