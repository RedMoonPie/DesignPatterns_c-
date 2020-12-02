using System;
namespace WeatherStation
{
    public class CHeatIndexDisplay:IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        public CHeatIndexDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);

        }
        public void Update(ISubject obs, Object arg)
        {
            if (obs is CWeatherData)
            {
                CWeatherData wd = (CWeatherData)obs;
                this.temperature = wd.Temperature;
                this.humidity = wd.Humidity;
                Display();
            }

        }
        public void Display()
        {   float T = temperature;
            float RH = humidity;
            float HI = (float)(-42.379 + 2.04901523 * T + 10.14333127 * RH - 0.22475541 * T * RH - 0.00683783 * T * T - 0.05481717 * RH * RH + 0.00122874 * T * T * RH + 0.00085282 * T * RH * RH - 0.00000199 * T * T * RH * RH);
            Console.WriteLine("The Heat Index is {0}", HI);
        }
    }
}
