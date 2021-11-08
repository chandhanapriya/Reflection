using System;
using System.Reflection;
using System.Text;


namespace Demo_Reflection
{
   class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Demo reflection in C#");
            Type T = typeof(int);
            Console.WriteLine("Type of name:{0}", T.Name);
            Console.WriteLine("Full name of Typedefined\t :{0}", T.FullName);
            Console.WriteLine("Type of assembly defined",T.Assembly);
            Console.WriteLine("Imaformation of base type\t {0}", T.BaseType);

            //creating an object
            Console.WriteLine("creating dynamic objects");
            Dynamic_Object O= new Dynamic_Object();
            O.firstmethod();
            O.Secondmethod();
            Dynamic_Object O1= new Dynamic_Object();
            O1.Secondmethod();
            O1.firstmethod();
           


        }
    }
}
