using System;
using System.Collections.Generic;
using System.ComponentModel;
using ThinkWellMobile.Models;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkWellMobile.Views {
	public partial class NewItemPage : ContentPage {
		public Item Item { get; set; }

		public NewItemPage() {
			InitializeComponent();
			BindingContext = new NewItemViewModel();
		}
	}
}