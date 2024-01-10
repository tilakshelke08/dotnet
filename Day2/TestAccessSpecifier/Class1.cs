using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccessSpecifier
{
    public class BaseClass {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_INTERNAL;

        
        void display()
        {
            System.Console.WriteLine("welcome to IACSD");
        }
    }
    
    }

