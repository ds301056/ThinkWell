using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ThinkWellMobile.Models;
using ThinkWellMobile.Views;
using Xamarin.Forms;

namespace ThinkWellMobile.ViewModels {
	public class VentDiaryViewModel : INotifyPropertyChanged {
		public ObservableCollection<DiaryEntry> DiaryEntries { get; set; }
		public ICommand CreateNewDiaryEntryCommand { get; set; }
		public ICommand OpenDiaryEntryCommand { get; set; }

		public VentDiaryViewModel() {
			DiaryEntries = new ObservableCollection<DiaryEntry>
			{
				new DiaryEntry { Title = "Sample Entry 1", Content = "Sample content 1", Date = DateTime.Now.AddDays(-2).ToString("g") },
				new DiaryEntry { Title = "Sample Entry 2", Content = "", Date = DateTime.Now.AddDays(-1).ToString("g") }
			};

			CreateNewDiaryEntryCommand = new Command(OnCreateNewDiaryEntry);
			OpenDiaryEntryCommand = new Command<DiaryEntry>(OnOpenDiaryEntry);
		}

		private async void OnCreateNewDiaryEntry() {
			string title = await Application.Current.MainPage.DisplayPromptAsync("New Diary Entry", "Enter a title:");

			if (!string.IsNullOrEmpty(title)) {
				DiaryEntry newEntry = new DiaryEntry {
					Title = title,
					Content = string.Empty,
					Date = DateTime.Now.ToString("g")
				};

				DiaryEntries.Add(newEntry);

				await Application.Current.MainPage.Navigation.PushAsync(new VentDiaryEntryPage {
					BindingContext = new VentDiaryEntryViewModel(newEntry, this)
				});
			}
		}

		private async void OnOpenDiaryEntry(DiaryEntry selectedEntry) {
			if (selectedEntry != null) {
				await Application.Current.MainPage.Navigation.PushAsync(
					new VentDiaryEntryPage(new VentDiaryEntryViewModel(selectedEntry, this)));
			}
		}

		public void UpdateDiaryEntry(DiaryEntry updatedEntry) {
			// Update the entry in the collection
			var existingEntry = DiaryEntries.FirstOrDefault(e => e.Title == updatedEntry.Title);
			if (existingEntry != null) {
				existingEntry.Content = updatedEntry.Content;
				existingEntry.Date = DateTime.Now.ToString("g");
			}
		}

		// INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}