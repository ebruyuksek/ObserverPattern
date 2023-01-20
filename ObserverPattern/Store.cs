
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Observer> Observers;

        public Store()
        {
            this.Observers = new List<Observer>();
        }

        public void AddSubscriber(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            Observers.ForEach(x =>
            {
                x.Update();
            });
        }
    }
}
