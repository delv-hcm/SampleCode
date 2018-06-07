using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;
[TestFixture]
    public class Class1
    {
        private Solution sl;
       
         public Class1()
        {
            sl = new Solution();
        }
        
       
          [TestCase(4,new int[] {1,4,4,4,5,3})]
          [TestCase(5, new int[] { 1, 4, 4, 4, 5, 3, 5, 5, 5, 5 })]
          [TestCase(1, new int[] { 1, 1,2,1 },Description="Boundary value")]
          [TestCase(4, new int[] { 1, 4, 4, 4, 5})]
          [TestCase(1, new int[] { 1},Description="specification value")]
        public void Test_migratoryBirds(int result,int[] bird)
        {
            var tmp=sl.migratoryBirds(bird);
           Assert.AreEqual(result, tmp);
           
            
        }
    }

