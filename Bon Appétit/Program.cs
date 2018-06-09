using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string[] input = Console.ReadLine().Split(' ');
            int[] line1 = Array.ConvertAll(input, Int32.Parse);
            int NumberofItem = line1[0];
            int k = line1[1];
            int[] ItemArray = new int[NumberofItem];

            ItemArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
           
            int AmountofMoney = Convert.ToInt32(Console.ReadLine());
            int totalCost = ItemArray.Sum() - ItemArray[k];
            int CostperPerson = totalCost / 2;

            if (AmountofMoney == CostperPerson)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(AmountofMoney - CostperPerson);
            }

            Console.ReadKey();
        }
    }
}