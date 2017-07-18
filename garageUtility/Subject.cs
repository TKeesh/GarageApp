using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace garageUtility
{
    public abstract class Subject
    {
        List<IObserver> listObservers = new List<IObserver>();

        public void Attach(IObserver inObserver) 
        {
            listObservers.Add(inObserver);
        }

        public void Detach(IObserver inObserver) 
        {
            listObservers.Remove(inObserver);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in listObservers) observer.UpdateView();
        }
    }
}
