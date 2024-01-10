using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o;
            o=new class1();
            int a;
            a = o.display();
                System.Console.WriteLine("welcome");

        }

        }
    public class class1
    {
       

        public int  display()
        {
            Console.WriteLine("start");
            int i;
            int value=0;
            if (value < 100)
            {
                i = value;
            }
            else
            {
                Console.WriteLine("end");
            }
            return display(); // show error 
        }
    }
        }

    

