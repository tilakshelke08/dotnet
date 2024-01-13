using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            display(1);
            Console.WriteLine(1);

            display2(Timeofday.EVENING);
            Console.WriteLine(Timeofday.EVENING);
            Console.ReadLine();
        }
        static void display(int t)
        {
            if (t == 0)
            {
                Console.WriteLine("GOOD MPORMIMG ");
            }
            else if (t == 1)
            {
                Console.WriteLine("GOOD AFTERNOON ");
            }
            else if (t == 2)
            {
                Console.WriteLine("GOOD EVENING  ");
            }
            else if (t == 3)
            {
                Console.WriteLine("GOOD NIGHT  ");
            }
        }


        static void display2( Timeofday t)
        {
            if (t == Timeofday.Morning)
            {
                Console.WriteLine("GOOD Morning ");
            }
            else if (t == Timeofday.AFTERNOON)
            {
                Console.WriteLine("GOOD AFTERNOON ");
            }
            else if (t == Timeofday.EVENING)
            {
                Console.WriteLine("GOOD EVENING  ");
            }
            else if (t == Timeofday.NIGHT)
            {
                Console.WriteLine("GOOD NIGHT  ");
            }
        }
        
    }
    public enum Timeofday
    {
        Morning,
         AFTERNOON, 
          EVENING,
          NIGHT,
    }
}
