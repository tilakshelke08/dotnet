using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class Program
    {
        static void Main()
        {
            class1 o1;
            o1 = new class1();
            o1.i = 100;
            o1.display();

      /*      ---------          */   

            class1 o2;
            o2 = new class1();
            o2.i = 200;
            class1.static_display();
        }
    }
    public class class1
    {
        public int i;
        public static int static_i; //single copy for claass 

        public static void static_display()
        {
            Console.WriteLine(static_i);
            
            Console.WriteLine(i); // non static cant acccesin static functions 
        }
        public void display()
        {
            Console.WriteLine(i);
            Console.WriteLine(static_i);
        }
    }
} 
