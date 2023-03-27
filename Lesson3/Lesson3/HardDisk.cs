using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class HardDisk : IHardDisk, IDevice
    {
        public string hardDiskProducer;
        public int hardDiskCapacity;

        public string ProducerName
        { get { return hardDiskProducer; } }

    
        public HardDisk(string hardDiskProducer, int hardDiskCapacity)
        {
            this.hardDiskProducer = hardDiskProducer;
            this.hardDiskCapacity = hardDiskCapacity;
        }
        public void Remove()
        {
            Console.WriteLine($"Hard disk {hardDiskProducer} with {hardDiskCapacity} capacity has been removed");
        }
    }
}
