using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WeatherApp
{
    public class App : Application
    {
        public App()
      
        {
            var dataService = new DataService();
            var model = new Model(dataService);
            var viewModel = new ViewModel(model);

            MainPage = new  WeatherPage(viewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
