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

            for (var i = 1; i <=100; i++)
                sum += i;

            Console.WriteLine($"Сума чисел вiд 1 до 100 = {sum}");
            Console.ReadLine();

        }
    }
}
