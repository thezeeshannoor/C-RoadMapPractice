using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsNamespace
{
    internal class Methods
    {
      public  static void Show(int age,string name="John Doe")
        {
           Console.WriteLine(age + " " + name); 

        }

        //pass by value method
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine($"Value is {a}");
        }

        //pass by refrence method
        public static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine($"Value is {a}");
        }

        //pass by out keyword method
        public static void PassByOut(out int a)
        {
            a = 10;
            Console.WriteLine($"Value is {a}");
        }
    }
}
