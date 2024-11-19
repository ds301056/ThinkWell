using System.Collections.Generic;
using System.ComponentModel;
using Microcharts;
using SkiaSharp;

namespace ThinkWellMobile.ViewModels {
	public class AnalyticsViewModel : INotifyPropertyChanged {
		public Chart PieChart1 { get; set; }
		public Chart PieChart2 { get; set; }
		public Chart PieChart3 { get; set; }

		public AnalyticsViewModel() {
			// Sample data for pie charts
			var entries1 = new List<ChartEntry>
			{
				new ChartEntry(20)
				{
					Color = SKColor.Parse("#0000ff"),
					ValueLabelColor = SKColor.Parse("#0000ff"),
					Label = "Male"
				},
				new ChartEntry(45)
				{
					Color = SKColor.Parse("#FFC0CB"),
					ValueLabelColor = SKColor.Parse("#FFC0CB"),
					Label = "Female"
				},
				new ChartEntry(35)
				{
					Color = SKColor.Parse("#BF40BF"),
					ValueLabelColor = SKColor.Parse("#BF40BF"),
					Label = "Other"
				},
			};

			var entries2 = new List<ChartEntry>
			{
				new ChartEntry(35)
				{
					Color = SKColor.Parse("#1E90FF"),
					ValueLabelColor = SKColor.Parse("#1E90FF"),
					Label = "Straight"
				},
				new ChartEntry(55)
				{
					Color = SKColor.Parse("#FF6347"),
					ValueLabelColor = SKColor.Parse("#FF6347"),
					Label = "Gay"
				},
				new ChartEntry(10)
				{
					Color = SKColor.Parse("#C1FFAD"),
					ValueLabelColor = SKColor.Parse("#C1FFAD"),
					Label = "Other"
				},
			};

			var entries3 = new List<ChartEntry>
			{
				new ChartEntry(60)
				{
					Color = SKColor.Parse("#87CEEB"),
					ValueLabelColor = SKColor.Parse("#87CEEB"),
					Label = "Category 1"
				},
				new ChartEntry(40)
				{
					Color = SKColor.Parse("#FFD700"),
					ValueLabelColor = SKColor.Parse("#FFD700"),
					Label = "Category 2"
				},
			};

			// Create pie charts
			PieChart1 = new DonutChart { Entries = entries1, LabelTextSize = 30f };
			PieChart2 = new DonutChart { Entries = entries2, LabelTextSize = 30f };
			PieChart3 = new DonutChart { Entries = entries3, LabelTextSize = 30f };
		}

		// INotifyPropertyChanged implementation
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
