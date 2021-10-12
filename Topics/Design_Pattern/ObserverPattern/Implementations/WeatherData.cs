using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementations
{
    class WeatherData : ISubject
    {

        private List<IObserver> _observersList;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            //Inicializar la lista de observadores al crear un Sujeto, para estar READY con los observers.
            this._observersList = new List<IObserver>();
        }

        //ISubject Implementation
        public  void RegisterObservers(IObserver observer)
        {
            this._observersList.Add(observer);
        }

        //ISubject Implementation
        public void RemoveObservers(IObserver observer)
        {
            this._observersList.Remove(observer);
        }

        //ISubject Implementation
        public void NotifyObservers()
        {
            foreach (IObserver observer in this._observersList)
            {
                observer.Update(this._temperature, this._humidity, this._pressure);
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }


        public float getTemperature()
        {
            return _temperature;
        }

        public float getHumidity()
        {
            return _humidity;
        }

        public float getPressure()
        {
            return _pressure;
        }

    }
}
