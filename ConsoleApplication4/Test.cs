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

class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int,int> myres=new List<int,int>();
        int count=0;
        while(n>=0){
            res+=n%2;
            if(res==1){ count++; myres.Add(res,count);}
            else res=0;
            n=n/2;
            
        }
            int max=0;
            foreach(var item in myres){
                max = Math.Max(item["1"], 0);
            }
            Console.WriteLine(max);
        
    }
}
