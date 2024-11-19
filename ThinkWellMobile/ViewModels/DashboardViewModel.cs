using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
using System.Windows.Input;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;

public class DashboardViewModel : BaseViewModel {
	public Chart Chart { get; set; }
	public ICommand VentDiaryCommand { get; }

	public DashboardViewModel() {
		// Sample data
		var entries = new List<ChartEntry>
		{
			new ChartEntry(70)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Monday"
			},
			new ChartEntry(55)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Tuesday"
			},
			new ChartEntry(60)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Wednesday"
			},
			new ChartEntry(80)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Thursday"
			},
			new ChartEntry(95)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Friday"
			},
			new ChartEntry(90)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Saturday"
			},
			new ChartEntry(90)
			{
				Color = SKColor.Parse("#0875da"),
				Label = "Sunday"
			}
		};

		// Create the chart
		Chart = new LineChart {
			Entries = entries,
			LineMode = LineMode.Straight,
			LineSize = 8,
			PointMode = PointMode.Circle,
			LabelOrientation = Orientation.Horizontal,
		};

		//Vent Diary go-to button from dashboard
		VentDiaryCommand = new Command(async () => await Shell.Current.GoToAsync("//VentDiaryPage"));
	}
}