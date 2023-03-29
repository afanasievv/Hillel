using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class PasswordGenerator
    {
        private static char[] allowedSymbols = 
            new String("1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM").ToCharArray();

        public static string Generate(int passwordLength)
        {
            var password = new StringBuilder();
            if (passwordLength > allowedSymbols.Length)
            {
                Console.WriteLine($"Пароль має бути не довше {allowedSymbols.Length} символiв");
                return password.ToString();
            }
            else
            {
                
                for (int i = 0; i < passwordLength; i++)
                {
                    Random randomIndex = new Random();

                    password.Append(allowedSymbols[randomIndex.Next(allowedSymbols.Length)]);
                }

                return password.ToString();
            }

        }
    }
}
