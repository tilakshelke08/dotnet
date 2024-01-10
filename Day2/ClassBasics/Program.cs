using n2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o;
            o = new class1();
            int ans;
            ans = o.display(c:20,b:10,a:30);
            System.Console.WriteLine("the total is :-");
            System.Console.WriteLine(ans);

        }
    }
    internal class Program1
    {
        static void Main1(string[] args)
        {
            System.Console.WriteLine("just time pass ");
        }
    }


}
namespace n2
{
     public class class1
    {
        public int display (int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
