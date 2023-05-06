using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal static class ArrayRandomValue
    {
        public static string GetRandomArrayValue(this string[] array)
        {
            Random random = new Random();
            return array[random.Next(0,array.Length)];
        }
    }
}
