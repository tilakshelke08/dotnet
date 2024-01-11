using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main()
        {

            /*       BaseClass o= new BaseClass(); */
            // error - cannot instantiate an abstract class 

            DerviedClass o = new DerviedClass();
         
        }
    }

    //abstarct class without any abstract members 
    public abstract class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("display");
        }

    }
    class DerviedClass : BaseClass {

        public void DeriveMethod()
        {
            Console.WriteLine("derived method ");
        }
    }
}


// orther examples

// abntract claass with abstract members 

public abstract class BaseClass2
{
    public abstract void display(); // abstract method  , contain on sighnature , no  code body 
    public abstract void Show();  // abstract method  , contain on sighnature , no  code body 

}
public class DerivedClass2 : BaseClass2
{
    public override void display()
    {
        Console.WriteLine("display");
    }
    public override void Show()
    {
        Console.WriteLine("show");
    }
}