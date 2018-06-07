using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class process
    {
      int[] convert_stringtoarray(string arr_){
          arr_ = arr_.Replace("\n", "0");
          arr_ = arr_.Replace("\t", "0");
          string[] arr=arr_.Split(' ');
         
          int[] res=new int[arr.Length];
          for(int i=0;i<arr.Length;i++){
             
              res[i]=int.Parse(arr[i]);
          }
          return res;
      }
      public string count_sp_thieu(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            string name = lines[0];
            string res;
            int[] type = convert_stringtoarray(lines[1]);
            int[] number = convert_stringtoarray(lines[2]);
            int[] sum = convert_stringtoarray(lines[3]);
            int min = sum[0];
            int keys = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                min = Math.Min(min, sum[i]);

            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > sum[i] && sum[i] == min)
                {
                    keys = type[i];
                    break;
                }

            }
            res = name + keys;
            if (keys == 0) return "0";
            else
                return res;
        }
    }
    class Program
    {
        
	
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao duong dan thu muc");
           
            
            string[] filePahts = System.IO.Directory.GetFiles(@"E:\athien\");
            process dt=new process();
            int dem_sp_loi=0;
            var mylist_sp_loi=new List<string>();
            foreach (string item in filePahts)
            {
                if (dt.count_sp_thieu(item) != "0") 
                { 
                    mylist_sp_loi.Add(dt.count_sp_thieu(item));
                    dem_sp_loi+=1;
                    foreach (string item2 in mylist_sp_loi)
                    {
                        Console.WriteLine(item2);
                       
                    }
                   
                    
                }

                else
                {
                    
                    Console.WriteLine("Du bo san pham ");
                }
            }
            Console.WriteLine("Tong so sp khong du bo: " + dem_sp_loi);
           
            Console.ReadLine();
        }
    }
}
