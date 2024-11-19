using System.ComponentModel;
using System.Runtime.CompilerServices;
using ThinkWellMobile.Models;

namespace ThinkWellMobile.ViewModels {
	public class VentDiaryEntryViewModel : INotifyPropertyChanged {
		private DiaryEntry _diaryEntry;
		private VentDiaryViewModel _parentViewModel;

		public DiaryEntry DiaryEntry {
			get => _diaryEntry;
			set {
				if (_diaryEntry != value) {
					_diaryEntry = value;
					OnPropertyChanged();
				}
			}
		}

		public VentDiaryEntryViewModel(DiaryEntry diaryEntry, VentDiaryViewModel parentViewModel) {
			DiaryEntry = diaryEntry;
			_parentViewModel = parentViewModel;
		}

		public void OnAppearing() {
			// Do any additional tasks when the page appears
		}

		public void SaveChanges() {
			// Save changes and update the parent ViewModel
			_parentViewModel.UpdateDiaryEntry(DiaryEntry);
		}

		// INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
