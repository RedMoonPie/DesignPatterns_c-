using System;
using System.Collections;

namespace WeatherStation
{
    public class CWeatherData:ISubject
    {
        private ArrayList observers;
        private Boolean changed;
        private float temperature;
        private float humidity;
        private float pressure;

        public CWeatherData()
        {
            observers = new ArrayList();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);

        }
        public void RemoveObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(i);
            }
        }
        public void setChanged()
        {
            changed = true;
        }
        public void NotifyObservers(Object arg)
        {
            if (changed)
            {
                foreach (IObserver obs in observers)
                {
                    obs.Update(this, arg);
                }
                changed = false;
            }
        }
        public void MeasurementsCHanged()
        {
            setChanged();
            NotifyObservers(null);
        }
        public void SetMeasurements(float temperature , float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsCHanged();


        }
        public float Temperature { get { return temperature; } }
        public float Humidity { get { return humidity; } }
        public float Pressure { get { return pressure; } }
    }
}
