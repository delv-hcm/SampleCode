using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class PersonCompare_Name : IComparer<Person>
    {
        public int Compare(Person a,Person b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }
}
