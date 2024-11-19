using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class LoadingViewModel : BaseViewModel {
		private string imageUrl;
		public string ImageUrl {
			get { return imageUrl; }
			set { SetProperty(ref imageUrl, value); }
		}

		public async Task LoadRandomAnimalImageAsync() {
			try {
				// Append a random query parameter to the URL to ensure it's not cached
				string imageUrl = "https://source.unsplash.com/featured/?cute-animals&" + Guid.NewGuid();
				ImageUrl = imageUrl;
			}
			catch (Exception ex) {
				// Handle exceptions, e.g., network errors
				Console.WriteLine("Error fetching image: " + ex.Message);
			}
		}
	}
}