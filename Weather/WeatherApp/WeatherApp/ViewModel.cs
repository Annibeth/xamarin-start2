using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Model model;
        private Weather currentWeather;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel(Model model)
        {

            this.model = model;
        }

        public Weather CurrentWeather
        {
            get
            {
                return currentWeather;
            }
            private set
            {
                currentWeather = value;
                NotifyPropertyChanged("CurrentWeather");
            }
        }
        public async Task UpdateAllWeather(string city)
        {
            CurrentWeather = await model.GetWeather(city);
        }


        private void NotifyPropertyChanged(string property)
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(property));
            }


        }
    }
}
