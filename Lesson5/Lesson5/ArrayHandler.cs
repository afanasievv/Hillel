using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5
{
    public class ArrayHandler
    {
        public delegate bool Check(double x);
        public event  EventHandler IntValueHandler;

        private double[] arrayOfNumbers;
        public ArrayHandler(double[] array)
        {
            this.arrayOfNumbers = array;
        }

        public IEnumerable<double> SquareRoots(Check check)
        {
            var result = arrayOfNumbers.Square();

            foreach (double number in result)
            {
                if (check(number))
                {
                    var args = new IntegerNumberEventArg() { Number = number };
                    IntValueHandler(this,args);

                    yield return number;
                        
                }
            }           
        }
        protected virtual void IntableValue(IntValueEventArgs e)
        {
            IntValueHandler?.Invoke(this, e);
        }  
        public static void On_IntableValue(object sender,IntValueEventArgs e)
        {
            Console.WriteLine("Значення ціле");
        }

        

    }
}
