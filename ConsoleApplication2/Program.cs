using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b)
    {
        /*
         * Write your code here.
         */
        int min = b.Min();
        
        int[] d = new int[100];
       
        int m = 0;
        int count = 0;
        for (int x = 1; x < 101; x++)
        {
             count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (x % a[i] == 0 && x >= a[i]&&x<=min)
                {

                    count++;

                }
            }
            if (count == a.Length) { d[m] = x; m++; }
        }
        int dem2 = 0;
        int dem = 0;
        for (int j = 0; j < m; j++)
        {
            dem = 0; 
            for (int k = 0; k < b.Length; k++)
            {
                if (b[k] % d[j] == 0)
                {
                    dem+=1;
                   
                   
                }
            }
            if (dem == b.Length) dem2 += 1;
        }

        return dem2;

    }

    static void Main(string[] args)
    {
       

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        Console.WriteLine(total);
        Console.ReadLine();

       
    }
}