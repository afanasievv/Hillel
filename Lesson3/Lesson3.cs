using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SecondLesson.Program;

namespace SecondLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hardDisk = new HardDisk("HP", 1000);
            var processor = new Processor("Intel", 3000);
            var compuctor = new Computer();
            compuctor.SetDevice(hardDisk);

        }
        public class Computer
        {
            private bool disposed = false;

            public List<object> ramConnectors = new List<object>(4);
            public List<object> hardDisksConnectors = new List<object>(2) { };
            public object processorConnector;

            public void SetDevice(object obj)
            {
                if (obj is IHardDisk)
                {

                    hardDisksConnectors.Add(obj);
                    // Console.WriteLine(hardDisksConnectors[0].hardDiskProducer);
                }
                else if (obj is IProcessor)
                {
                    Processor proc = (Processor)obj;
                    processorConnector = proc.processorProducer;
                    //Console.WriteLine(processorConnector.);
                }
                else if (obj is IRam)

                { //ramConnectors.Add((Ram)obj);
                    //Console.WriteLine(ramConnectors[0].);
                }

            }

            public void Dispose()
            {
                CleanUp(true);
                GC.SuppressFinalize(this);
            }
            ~Computer()
            {
                Console.WriteLine("Finalize!");
                CleanUp(false);
            }
            private void CleanUp(bool clean)
            {
                if (!this.disposed)
                {
                    if (clean)
                    {


                    }
                    Console.WriteLine("Finalized");
                }
                this.disposed = true;
            }
        }

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
        public class HardDisk : IHardDisk
        {
            public string hardDiskProducer;
            public int hardDiskCapacity;
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
        public class Processor : IProcessor
        {
            public string processorProducer;
            public int processorFrequency;
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
        //public interface IDevice
        //{
        //void SetDevice();
        //}
        public interface IRam
        {
            void Eject();
        }
        public interface IHardDisk
        {
            void Remove();
        }
        public interface IProcessor
        {
            void Unplug();
        }
        

    }
}
