using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class DateTimeGenerator: IDateTimeGenerator
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        public DateTime GetRandomDateTime()
        {
            Random random = new Random();
            DateTime start = new DateTime(1900, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
        

    }
}
