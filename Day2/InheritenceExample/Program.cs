using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static InheritenceExample2.Program;

namespace InheritenceExample1
{
    internal class Program
    {
        static void Main1()
        {
/*
            BaseClass o = new BaseClass();*/

        }
    }
    public class BaseClass {
        public int i;

    }
    public class DerivedClass : BaseClass
    {
        public int j;
    }
}
namespace InheritenceExample2
{
  
        internal class Program
        {
            static void Main()
            {
            TestAccessSpecifier.BaseClass o2 = new TestAccessSpecifier.BaseClass();




            }
        }
        public class Baseclass
        {
            public int PUBLIC;
            private int PRIVATE;
            protected int PROTECTED;
            internal int INTERNAL;
            protected internal int PROTECTED_INTERNAL;
            private protected int PRIVATE_INTERNAL;
        }
        public class DerivedClass : TestAccessSpecifier.BaseClass //Baseclass
        {
            void DoNothing()
            {
                Console.WriteLine("welcome");
            }
        }
    
    
}

