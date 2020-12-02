using System;

namespace WeatherStation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CWeatherData weatherData = new CWeatherData();

            CurrentCOnditionDIsplay currentDisp = new CurrentCOnditionDIsplay(weatherData);
            CHeatIndexDisplay hdisplay = new CHeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(12, 34, 44.3f);
            weatherData.SetMeasurements(22, 14, 32.1f);
            weatherData.SetMeasurements(32, 24, 12.8f);
            weatherData.SetMeasurements(42, 88, 21.0f);


        }
    }
}
