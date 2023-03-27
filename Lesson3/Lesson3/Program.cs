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
            var hardDisk = new HardDisk("SanDisk", 1000);
            var processor = new Processor("Intel", 3000);
            var ram = new Ram("Kingston", 32);
            var compuctor = new Computer();
            compuctor.AddDevice(hardDisk);
            compuctor.AddDevice(processor);
            compuctor.AddDevice(ram);

            Console.WriteLine(compuctor.hardDisksConnectors[0].ToString());
           

            Console.ReadLine();

        }      
          
    }
}
