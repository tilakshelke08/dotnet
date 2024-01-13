using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    internal class Program
    {
        static void Main()
        {
            /* int a;
             a = 100;
             a = null;
             a = ReadValueFromDb();
             Console.WriteLine("done ");*/

            int? i = 10;
            //i = null;   //10
            int j;
            if (i != null)
            {
                j = (int)i;

            }                 // 0
            else
            {
                j=0;
            }
            Console.WriteLine(j);

        }
    }
}
