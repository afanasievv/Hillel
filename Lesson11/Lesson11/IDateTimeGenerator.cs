﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal interface IDateTimeGenerator
    {
        DateTime GetCurrentDateTime();
        DateTime GetRandomDateTime();
    }
}