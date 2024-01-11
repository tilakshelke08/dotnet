using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* namespace RefAndValType
{
    internal class Program
    {
        static void Main(string[] args)
        { // reference type

            class1 o1 = new class1();
            class1 o2= new class1();
            o1.i = 100;
            o2.i = 200;
            o1 = o2;   // both are pointing to same directtion 
            o2.i = 300;
            Console.WriteLine(o1.i); //300
            Console.WriteLine(o2.i);  //300
            Console.ReadLine();
        }
    }
    public class class1
    {
        public int i;
    }
} */

internal class Program
{
    static void Main()
    {//value type
        int o1, o2 ;
        
        o1= 100;
        o2 = 200;
        o1 = o2;   // both are pointing to same directtion 
        o2 = 300;
        Console.WriteLine(o1);//200
        Console.WriteLine(o2);//300
        Console.ReadLine();
    }
}
public class class1
{
    public int i;
}
}
