using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patrns
{
    class JobSite : IObserved
    {
        private List<String> vacacies = new List<string>();
        private List<IObserver> observers = new List<IObserver>();

        public void addVacacies (String vacaciy)
        {
            this.vacacies.Add(vacaciy);
            notifyObservers();
        }
        public void removeVacacies (String vacaciy)
        {
            this.vacacies.Remove(vacaciy);
            notifyObservers();
        }

        public void addObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.handleEvent(this.vacacies);
            }
        }

        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
