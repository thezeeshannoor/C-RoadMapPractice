using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Fun
    {
        //public void Funct()
        //{
        //    Console.WriteLine("additional function added using extension method1");
        //}
    }
    static class ExtensionMethod`    
    {
        // this Fun p called binding parameter
        // this means that our function belong to the static class
        public static void Funct(this Fun p,string name)
        {
            Console.WriteLine("Additional function added using Extension method2\t"+name);
        }
    }
}
