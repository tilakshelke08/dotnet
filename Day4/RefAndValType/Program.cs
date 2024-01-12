using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValType
{
    internal class Program
    {
        static void Main()
        {
            class1 o = new class1();

            o.i = 100;
            Dosomething1(o);
            Console.WriteLine(o.i);
            Console.ReadLine();
        }
        static void Dosomething1(class1 obj)
        {
        
            obj.i = 200;
        }
        public class class1
        {
            public int i;
        }
    }
}
