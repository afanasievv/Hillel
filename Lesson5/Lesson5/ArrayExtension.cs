using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class ArrayExtension
    {public static IEnumerable<double> SquareRoots(this double[] array)
        {
            foreach(var number in array)
            {
                yield return Math.Sqrt(number);
            }
        }
    }
}
