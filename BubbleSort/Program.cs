using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tmp = Console.ReadLine().Split(' ');
            int[] input = Array.ConvertAll(tmp, Int32.Parse);
            Console.WriteLine("Processing........");
            BubbleSort(input);
            Console.ReadKey();
        }
        static void BubbleSort(int[] data)
        {
            int length = data.Length;
            int countsoft = 0;

            for (int i = 0; i < length; i++)
            {
                int numberofswap=0;
                for (int j = 0; j < length - 1; j++)
                {
                    if(data[j]>data[j+1]){
                        int tmp=data[j];
                        data[j]=data[j+1];
                        data[j + 1] = tmp;
                        numberofswap++;
                    }
                }
                countsoft += numberofswap;
                Console.Write("Data after sorted {0}: ", i + 1);
                foreach (int item in data)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Array is sorted in {0} swaps", countsoft);
        }
    }
}
