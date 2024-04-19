using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegationNamespace;

public delegate void Calculation(int a,int b); 
internal class Delegation
{
    public static void Addtion(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    public static void Subtraction(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}
