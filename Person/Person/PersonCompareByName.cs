using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class PersonCompareByName : Comparer<Person>
    {
        public override int Compare(Person x, Person y)
        {
            
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
