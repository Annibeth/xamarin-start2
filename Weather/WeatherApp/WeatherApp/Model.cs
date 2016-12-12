using System;
using System.Globalization;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Model
    {
        private string cityCode;
        private DataService dataService;

        public Model(DataService dataService)
        {
            this.dataService = dataService;
        }
        
         
        public async Task<Weather> GetWeather(string cityCode)
        {
            //Sign up for a free API key at http://openweathermap.org/appid
            string key = "d7ad57c25dc63896ccbdc046d132943e";
            //string latitude = "55.676098";
            //string longitude = "12.5683";
            


            //string queryString = "http://api.openweathermap.org/data/2.5/weather?lat="
            //     + latitude + "&lon=" + longitude + "&units=metric&appid=" + key;


            string queryString = "http://api.openweathermap.org/data/2.5/weather?q="
               + cityCode + "&units=metric&appid=" + key;

            var results = await dataService.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime dt = time.AddSeconds((double)results["dt"]).ToLocalTime();
                weather.DatoTid = dt.ToString("dddd', Den 'dd MMMM yyyy", new CultureInfo("da"));
                weather.Temperature = (string)results["main"]["temp"] + " C";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}