using System;
namespace InterfacesWithDotnetCore
{
class Program
    {
        static void Main()
        {
            CLASS1 o;
            o = new CLASS1();
            (o as IDbfunction).select();



            /*            //this is Method1
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


            */

            Console.WriteLine("interface done ");
            Console.ReadLine();
        }
    }
    public interface IDbfunction
    {
        void Insert();
        void Update();
        void Delete();


        //if class not call the method when used this 
       
         public void select() // default method if class not call the method 
        {
            Console.WriteLine("default method ");
        }
    }
    

public class CLASS1 : IDbfunction
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
}