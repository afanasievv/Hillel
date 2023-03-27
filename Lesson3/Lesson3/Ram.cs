using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class Ram : IRam, IDevice
    {
        public string ramProducer;
        public int ramCapacity;

        public string ProducerName
        { get { return ramProducer; } }

        
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
