using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25
{
    public class StringManipulator
    {
        public string ConcatenateStrings(string str1, string str2)

        {
            return str1 + str2;
        }
        public int GetStringLength(string str)
        {
            return str.Length;
        }

        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }
        public bool IsPalindrome(string str)
        {
            string reversedStr = ReverseString(str);

            return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
        }

    }
}
