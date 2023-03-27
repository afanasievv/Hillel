using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class Processor : IProcessor, IDevice
    {
        public string processorProducer;
        public int processorFrequency;

        public string ProducerName
        { get { return processorProducer; } }

        public string ProcessorProducer
        {
            get { return processorProducer; }
        }
        public Processor(string processorProducer, int processorFrequency)
        {
            this.processorProducer = processorProducer;
            this.processorFrequency = processorFrequency;
        }
        public void Unplug()
        {
            Console.WriteLine($"Processor {processorProducer} with {processorFrequency} capacity has been removed");
        }
    }
}
