﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class PersonCompareByAge : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
