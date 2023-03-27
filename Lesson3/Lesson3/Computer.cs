using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson
{
    public class Computer : IDevice
    {
        private bool disposed = false;

        public List<object> ramConnectors = new List<object>(4);
        public List<object> hardDisksConnectors = new List<object>(2);
        public object processorConnector;


        public void AddDevice(object obj)
        {
            if (obj is IHardDisk)
            {
                hardDisksConnectors.Add(obj);  
                
            }
            else if (obj is IProcessor)
            {
              processorConnector = (Processor)obj;
               
            }
            else if (obj is IRam)

            {
                ramConnectors.Add(obj);
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
                    ramConnectors = null;
                    hardDisksConnectors = null;
                    processorConnector = null;
                }
                Console.WriteLine("Finalized");
            }
            this.disposed = true;
        }
    }
}
