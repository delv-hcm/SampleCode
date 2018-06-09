using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
   public class PersonCompare:IComparer
    {
       public int Compare(object x, object y)
       {
           Person p1 = x as Person;
           Person p2 = y as Person;
           if (p1 == null || p2 == null)
           {
               throw new Exception("Doi tuong rong");
           }
           else
           {
               if (p1.Tuoi > p2.Tuoi)
               {
                   return 1;
               }
               else if (p1.Tuoi == p2.Tuoi)
               {
                   return 0;
               }
               else
               {
                   return -1;
               }

           }
       }
    }
}
