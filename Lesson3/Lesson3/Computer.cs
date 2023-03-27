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

        public List<IRam> ramConnectors = new List<IRam>(4);
        public List<IHardDisk> hardDisksConnectors = new List<IHardDisk>(2);
        public object processorConnector;

       
        public void AddDevice(IDevice device)
        {
            if (device is IHardDisk)
            {
                hardDisksConnectors.Add(device as IHardDisk);  
                
            }
            else if (device is IProcessor)
            {
              processorConnector = (IProcessor)device;
               
            }
            else if (device is IRam)

            {
                ramConnectors.Add(device as IRam);
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
