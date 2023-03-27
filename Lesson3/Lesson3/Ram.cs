using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class Ram : IRam
    {
        public string ramProducer;
        public int ramCapacity;
        public Ram(string ramProducer, int ramCapacity)
        {
            this.ramProducer = ramProducer;
            this.ramCapacity = ramCapacity;
        }
        public void Eject()
        {
            Console.WriteLine($"Hard disk {ramProducer} with {ramCapacity} capacity has been removed");
        }
    }
   
}
