using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o;
            o = new class1();
            o.I = 500;  //setter 
            Console.WriteLine(o.I); // getter
            Console.ReadLine();
        }
/*______________________________________________________________________
        // not using this method 

        *//*  class1 o;
          o= new class1();
          // o.i = 500;
          // Console.WriteLine(o.i);
          o.seti(500);
          Console.WriteLine(o.geti());
          Console.ReadLine();
      }
  }
  public class class1 {
      public int i;
      public void seti(int value )
      {
          if( value < 100 ) { 
          i= value;
          }
          else
          {
              Console.WriteLine("invalid i ");
          }
      }
      public int  geti()
      {
          return i;
      }
  }*//*
______________________________________________________________________*/
        //again start 
        public class class1
        {
            private int i;
            public int I //property
            {
                set
                {
                    if (value < 500)
                    {
                        i = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid i");
                    }
                }
                get
                {
                    return i;
                }
            }
        }

    }
}
