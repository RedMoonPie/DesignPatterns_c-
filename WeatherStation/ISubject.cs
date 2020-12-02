using System;
namespace WeatherStation
{
    public interface ISubject
    {

        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(object arg);


    }
    public interface IObserver
    {
        void Update(ISubject obs,Object arg);
    }

    public interface IDisplayElement
    {
         void Display();
    }


}
