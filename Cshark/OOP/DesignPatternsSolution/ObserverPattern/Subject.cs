using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
   public class Subject
    {
        private List<Observer> _observers = new List<Observer>();
        private int _state;

        public int GetState()
        {
            return _state;
        }

        public void SetState(int state)
        {
            this._state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
