using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    internal class Program
    {
        static void Main1()
        {

            int i=new int();
          //  int i = 0;
            Console.WriteLine(i);
            Console.ReadLine();

        }
        static void Main()
        {
           Mypoint p=new Mypoint(10,20,30);
            Console.WriteLine(p.A);
            Console.ReadLine();

        }
    }
    //struct Val type ---stored on stack ---faster than heap operation 
    //no inheritence allowed in struct
    // parameterless constuctor  not allowed in struct 
    public struct Mypoint
    {
        public int A
        {
            get; set;

        }

        public int X, Y;
        public Mypoint(int X = 0, int Y = 0, int A = 0)
        {
            Console.WriteLine("Cons called");
            this.X = X;
            this.Y = Y;
            this.A = A;


        }
    }
}
