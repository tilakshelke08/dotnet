using Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main()
        {
            //this is Method1
            // THIS IS NORMAL OBJECT CALL 
            CLASS1 o;
            o = new CLASS1();
            o.Insert();
            o.Update();
            o.Delete();

            //This  is Method2
            // YOU CAN CALL BY INTERFACE OBJ ALSO 
            IDbfunction IDb;
            IDb = o;
            IDb.Insert();
            IDb.Update();
            IDb.Delete();


            //THIS IS Method3
            //TYPECASTING 
            ((IDbfunction)o).Insert();
            ((IDbfunction)o).Update();
            ((IDbfunction)o).Delete();

            //THIS IS Method4
            //TYPECASTING 
            (o as IDbfunction).Insert();
            (o as IDbfunction).Update();
            (o as IDbfunction).Delete();




            Console.WriteLine("interface done ");
            Console.ReadLine();
        }
    }
    public interface IDbfunction
    {
        void Insert();
        void Update();
        void Delete();
    }
} public class CLASS1
{
    public void Insert()
    {
        Console.WriteLine("insert");
    }
    public void Update()
    {
        Console.WriteLine("Update");
    }
    public void Delete()
    {
        Console.WriteLine("Delete");
    }
    public void Display()  // this method only in claSS1
    {
        Console.WriteLine("Display");
    }
}

// above example with some aadd
namespace Interface1
{
    internal class Program
    {
        static void Main1()
        {
            //this is Method1
            // THIS IS NORMAL OBJECT CALL 
            CLASS1 o;
            o = new CLASS1();
            o.Insert();
            o.Update();
            o.Delete();

            //This  is Method2
            // YOU CAN CALL BY INTERFACE OBJ ALSO 
            IDbfunction IDb;
            IDb = o;
            IDb.Insert();
            IDb.Update();
            IDb.Delete();


            //THIS IS Method3
            //TYPECASTING 
            ((IDbfunction)o).Insert();
            ((IDbfunction)o).Update();
            ((IDbfunction)o).Delete();

            //THIS IS Method4
            //TYPECASTING 
            (o as IDbfunction).Insert();
            (o as IDbfunction).Update();
            (o as IDbfunction).Delete();




            Console.WriteLine("interface done ");
            Console.ReadLine();
        }
    }
    public interface IDbfunction
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFilefunction
{
        void open();
        void close();
        void Delete();
    }
}
public class CLASS2: IDbfunction, IFilefunction
{
    public void Insert()
    {
        Console.WriteLine("insert");
    }
    public void Update()
    {
        Console.WriteLine("Update");
    }
    public void Delete()
    {
        Console.WriteLine("Delete");
    }
    public void Display()  // this method only in claSS1
    {
        Console.WriteLine("Display");
    }
    // other interface explicitely 
    void IFilefunction.open()
    {
        throw new NotImplementedException();
    }

    void IFilefunction.close()
    {
        throw new NotImplementedException();
    }

    void IFilefunction.Delete()
    {
        throw new NotImplementedException();
    }
}
