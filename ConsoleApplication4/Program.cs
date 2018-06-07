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

public class Solution
{

    // Complete the migratoryBirds function below.
    public  int migratoryBirds(int[] ar)
    {
        int length = ar.Length;
        int[] res_ar = new int[6];
        res_ar[0] = 0;
        int tmp = 0;
        for (int i = 1; i <= 5; i++)
        {
            tmp = i;//type bird
            int count = 0;
            for (int j = 0; j < length; j++)
            {
                if (tmp == ar[j]) count++;

            }
            res_ar[i] = count;

        }
        int max = res_ar[1]; int res = 0;
       
        for (int j = 1; j < 6; j++)
        {
            if (res_ar[j] > max) { res = j; max = res_ar[j]; }
        }
        
            return res++;

    }

    static void Main(string[] args)
    {
       // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        string[] data = File.ReadAllLines("E:\\input03.txt");
        string[] data_ = data[1].Split(' ');
        int length=data_.Length;
        int[] ar = new int[length];
        for (int i = 0; i <length ; i++)
        {
            ar[i] = int.Parse(data_[i]);
        }
       //int result = migratoryBirds(ar);

        //Console.WriteLine(result);

        Console.ReadLine();
    }
}