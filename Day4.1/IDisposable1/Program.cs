using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable
{
    internal class Program
    {
        static void Main()
        {
            class1 o = new class1();
            o.display();

            Console.ReadLine();
        }

    }
    public class class1 : IDisposable1
    {

        public class1()
        {
            //open file 
            //open db file 
            Console.WriteLine("class1 constructor ");

        }
  
    public void display()
    {

        Console.WriteLine(" display called ");

    }
    public void dispose()
    {
        // close file 
        //close db 
        Console.WriteLine("dispose code callled . right cod here instead of destructor ");
    }
    }
    
}
