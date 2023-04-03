using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class ArrayHandler
    {
        public event EventHandler<IntegerNumberEventArg> IntegerableNumber;

        public double[] arrayOfNumbers;
        public ArrayHandler(double[] array)
        {
            this.arrayOfNumbers = array;
        }
        public void SquareRoots()
        {
            var result = arrayOfNumbers.SquareRoots();
            foreach (var number in result) ;
            Console.WriteLine(result);
        }
        

    }
}
