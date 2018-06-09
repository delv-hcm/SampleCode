using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Arraylist
{   
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList person = new ArrayList();
            person.Add(new Person("Nguyen Van B", 25));
            person.Add(new Person("Le Van A", 19));
            person.Add(new Person("Le Van A", 20));
            
            person.Sort(new PersonCompare());

            foreach (Person p in person)
            {
                Console.WriteLine(p.Name +" "+ p.Tuoi);
            }
            Console.WriteLine("---------------------------");
            List<Person> person_ = new List<Person>();
            person_.Add(new Person("Nguyen Van C", 25));
            person_.Add(new Person("Le Van D", 19));
            person_.Add(new Person("Le Van E", 20));
           
            person_.Sort(new PersonCompare_Name());
            foreach (Person p in person_)
            {
                Console.WriteLine(p.Name + " " + p.Tuoi);
            }
            Console.ReadKey();
            /**
             * IComparable được cài đặt trực tiếp ngay trên lớp các đối tượng trong danh sách,
             * còn IComparer thì được cài đặt trên một lớp riêng . 
             * **/
        }
    }
}
