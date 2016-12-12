using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {


        private ViewModel viewModel;

        public WeatherPage(ViewModel viewModel)
        {
            InitializeComponent();


            this.viewModel = viewModel;
            BindingContext = viewModel.CurrentWeather;


        }

        private async void OnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cityEntry.Text))
            {
                await viewModel.UpdateAllWeather(cityEntry.Text);
                BindingContext = viewModel.CurrentWeather;
            }
            if (viewModel.CurrentWeather != null)
            {
                this.BindingContext = viewModel.CurrentWeather;
                getWeatherBtn.Text = "Søg igen!";
            }
        }



    }
}

//this.Title = "Opgave asns Weather App";
//getWeatherBtn.Clicked += OnClicked;

//    //Set the default binding to a default object for now
//this.BindingContext = new Weather();
//private async void OnClicked(object sender, EventArgs e)
//{
//    if (!String.IsNullOrEmpty(cityEntry.Text))
//    {
//        Weather weather = await Model.GetWeather(cityEntry.Text);
//        if (weather != null)
//        {
//            this.BindingContext = weather;
//            getWeatherBtn.Text = "Søg igen!";
//        }
//    }}