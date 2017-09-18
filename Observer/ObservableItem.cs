using System;
using System.Collections.Generic;

namespace Observer
{
    public class Collection : IObservable
    {
        private Number _value;

        private readonly List<IObserver> _observers;

        public Number Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    NotifyObservers();
                }
            }
        }

        public Collection()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
            Console.WriteLine("Observer registered");
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
            Console.WriteLine("Observer unregistered");
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_value);
            }
        }
    }
}
