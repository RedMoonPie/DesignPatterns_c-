using System;
namespace WeatherStation
{
    public class CurrentCOnditionDIsplay:IObserver,IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;//subscripcion
        public CurrentCOnditionDIsplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(ISubject obs,Object arg)
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
        {
            Console.WriteLine("Current condition: {0} F degrees and {1} humidity ", temperature, humidity);
        }

       
    }
}
