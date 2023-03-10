using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for (var i = 0; i < 100; i++)
                sum += i;
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
