using System;
using ClassBasics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Program
    {
        static void Main1(string[] args) //this is Main1 method 
            //this is not Main method 
        {

            System.Console.WriteLine("hello world ");
            System.Console.WriteLine("enter the name :-");
            System.Console.ReadLine();
            
        }
        //method overloading 
        public int  Add(int a,int b)
        {
            return a + b;      
        }
        //optional parameter with default values
        public int Add1(int a = 0,int b=0,int c=0)
        {
            return a + b + c;
        }
    }
}
namespace n2
{
    class class1
    {
        static void Main(string[] args)
        {
            int result; 
            Program o; // o is ref type 
            o = new Program(); //new program() is instance of program 
             result= o.Add(2, 3);            System.Console.WriteLine("hello world ");
            System.Console.WriteLine("Add:-" +result);
            int d;
            d = o.Add1(5, 4, 1);
            System.Console.WriteLine("Add1:-" +d);
            //  System.Console.ReadLine();

        }
    }
}
