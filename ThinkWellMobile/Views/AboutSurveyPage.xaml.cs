using System;
using System.Windows.Input;
using ThinkWellMobile.ViewModels;
using Xamarin.Forms;

namespace ThinkWellMobile.Views
{
    public partial class AboutSurveyPage : ContentPage
    {
        public AboutSurveyPage()
        {
            InitializeComponent();
			this.BindingContext = new AboutSurveyViewModel();
        }
    }
}