using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
   public class Person
    {
       public string Name {get;set;}
       public int Tuoi { get; set; }
       public Person(string ten, int tuoi){
           this.Name=ten;
           this.Tuoi=tuoi;
       }
       public int CompareTo(Person other)
       {
           return this.Tuoi.CompareTo(other.Tuoi);
       }


    }
}
