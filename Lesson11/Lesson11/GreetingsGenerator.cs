using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class GreetingsGenerator: IGreetingsGenerator
    {
        public string GetGreeting()
        {
            string[] arrayOfGreetings = new string[] { "Hi,", "Hello,", "What's up?," };
            return arrayOfGreetings.GetRandomArrayValue();

        }

    }
}
