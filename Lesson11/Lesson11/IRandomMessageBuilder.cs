using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal interface IRandomMessageBuilder
    {
        void AddDateTime(bool isRandom);
        void AddGreeting();

        void AddName();

        void Result();
    }

}
