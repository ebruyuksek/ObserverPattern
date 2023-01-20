using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var store = new Store
            {
                Id = 1,
                Name = "StarStore"
            };

            var getObserverName = Console.ReadLine().ToString().Split(' ').First();

            store.AddSubscriber(new UserObserver() { Name = getObserverName});
            store.Notify();

            Console.ReadLine(); 

          
        }
    }
}
