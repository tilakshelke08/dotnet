using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValType3
{
    internal class Program
    {
        static void Main()
        {
            class1 o = new class1();

            o.i = 100;
            //  Dosomething1(o);
            // Dosomething2(o);
            Dosomething3(ref o);
            Console.WriteLine(o.i);
            Console.ReadLine();
        }
        static void Dosomething1(class1 obj)
        {

            obj.i = 200;
        }
        static void Dosomething2(class1 obj)
        {
            obj = new class1();
            obj.i = 200;
        }
        static void Dosomething3( ref class1 obj)
        {
            obj = new class1();
            obj.i = 300;
        }
        public class class1
        {
            public int i;
        }
    }
}

