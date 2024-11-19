using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class DailyViewModel : BaseViewModel {
		public DailyViewModel() {
			OnBeginCommand = new Command(async () => await Shell.Current.GoToAsync("//SurveyPage"));
			OnSkipCommand = new Command(async () => await Shell.Current.GoToAsync("//DashboardPage"));
			OnLearnMoreCommand = new Command(async () => await Shell.Current.GoToAsync("//AboutSurveyPage"));
		}

		// Define a command for the "Begin" button
		public ICommand OnBeginCommand { get; }
		public ICommand OnSkipCommand { get; }
		public ICommand OnLearnMoreCommand { get; }
	}
}