using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class UserObserver : Observer
    {
        public string Name { get; set; }
        public override void Update()
        {
            Console.WriteLine( this.Name + " has notified");
        }
    }
}
