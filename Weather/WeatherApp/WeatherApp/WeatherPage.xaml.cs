using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Opgave Weather App";
            getWeatherBtn.Clicked += OnClicked;

            //Set the default binding to a default object for now
            this.BindingContext = new Weather();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cityEntry.Text))
            {
                Weather weather = await Core.GetWeather(cityEntry.Text);
                if (weather != null)
                {
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Search Again";
                }
            }
        }
    }
}