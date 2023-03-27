using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
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
                //Console.WriteLine(hardDisksConnectors[0]);
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
}
