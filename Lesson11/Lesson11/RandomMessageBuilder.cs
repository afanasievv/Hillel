using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class RandomMessageBuilder : IRandomMessageBuilder
    {
        private readonly IDateTimeGenerator dateTimeGenerator;
        private readonly IGreetingsGenerator greetingsGenerator;
        private readonly INamesGenerator namesGenerator;
        StringBuilder sb = new StringBuilder();

        public RandomMessageBuilder(IDateTimeGenerator dateTimeGenerator, GreetingsGenerator greetingsGenerator, INamesGenerator namesGenerator)
        {
            this.dateTimeGenerator = dateTimeGenerator;
            this.greetingsGenerator = greetingsGenerator;
            this.namesGenerator = namesGenerator;
        }

        public void AddDateTime(bool isRandom)
        {
            if (!isRandom) sb.Insert(0, dateTimeGenerator.GetRandomDateTime() + " ");
            else sb.Insert(0, dateTimeGenerator.GetCurrentDateTime()+" ");
        }

        public void AddGreeting()
        {
            sb.Append(greetingsGenerator.GetGreeting() + " ");

        }

        public void AddName()
        {
            sb.AppendFormat(namesGenerator.GetName());
        }

        public void Result()
        {
            Console.WriteLine(sb);
        }
    }
}
