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



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary <int,int> myres = new Dictionary<int,int>();
 
        int count = 0;
        int res = 0;
        while (n >= 0)
        {
            res = n % 2;
            if (res == 1) { count++; myres.Add(res, count); }
            else { count = 0; myres.Add(res, count); }
            n = n / 2;

        }
        List<int> list = new List<int>(myres.Keys);
        int max = 0;
        foreach(int i in list){
            max = Math.Max(max, myres[i]);
        }
        Console.WriteLine(max);

    }
}
