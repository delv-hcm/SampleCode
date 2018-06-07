using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int res = 0;
        int sum = 0;
        for (int i = 0; i < n - 1; i++)
        {
            sum = ar[i];
            for (int j = i + 1; j < n; j++)
            {
                sum += ar[j];
                if (sum % k == 0) res++;
                    sum = ar[i];
            }

        }
        return res;
    }

    static void Main(string[] args)
    {
       

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);

        
        Console.ReadLine();
    }
}