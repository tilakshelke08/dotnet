using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    internal class Program
    {
        static void Main()

        {
            DerviedClass o= new DerviedClass();
            /* o.display1();
             o.display1("Tilak");
            o.display2();*/
            o.display3();
            Console.WriteLine("welcome");
        }
    }
    public class BaseClass
    {
        public void display1()
        {
            Console.WriteLine("DISPLAY1");
        }
        public void display2()
        {
            Console.WriteLine("DISPLAY2");
        }
        public virtual void display3()
        {
        Console.WriteLine("DISPLAY3");
        }
    }
    class DerviedClass : BaseClass
    {
        //overlioading the based class method 

        public void display1(string s)
        {
            Console.WriteLine("Dervived class  display1 :-" +s);
        }
        //hiding  the based class method 
        public void  display2()
        {
            Console.WriteLine("Dervived class  display2" );
        }
        //overriding the base class method 
        public override void display3()
        {
            Console.WriteLine("this is a override method ");
        }
    }

   
}

    
