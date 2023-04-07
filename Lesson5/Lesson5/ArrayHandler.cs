using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5
{
    public class ArrayHandler
    {
        public delegate void Check();
        public event EventHandler<IntegerNumberEventArg> IntegerableNumber;

        public double[] arrayOfNumbers;
        public ArrayHandler(double[] array)
        {
            this.arrayOfNumbers = array;
        }
        public void SquareRoots(Check check)
        {
            double[] result = (double[])arrayOfNumbers.Square();
            
            foreach (var number in result) ;
            Console.WriteLine();
        }
       
        

    }
}
