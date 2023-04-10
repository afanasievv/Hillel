using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson5
{
    public class ArrayHandler
    {
        public delegate bool CheckValue(double x);
        public event  EventHandler <IntegerNumberEventArg> IntValueHandler;

        private double[] arrayOfNumbers;
        public ArrayHandler(double[] array)
        {
            this.arrayOfNumbers = array;
        }

        public IEnumerable<double> SquareRoots(CheckValue check)
        {
            var sortArray = arrayOfNumbers.Sqrt();

            foreach (double number in sortArray)
            {
                if (check(number))
                {                   
                    var args = new IntegerNumberEventArg() { Number = number };
                                            
                    IntValueHandler(this,args);
                    
                    yield return number;
                        
                }   
            }           
        }
        protected virtual void IntableValue(IntegerNumberEventArg e)
        {
            IntValueHandler?.Invoke(this, e);
        }  
                       
    }
}
