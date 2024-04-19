using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorNamespace;

internal class Constructors
{
   public int age = 10;
    //default constructor
    public Constructors()
    {
        Console.WriteLine("Default constructor called");
    }
    //static constructor
    static Constructors()
    {
        Console.WriteLine("static constructor called");
    }

    //Parametrized constructor
    public Constructors(string name)
    {
        Console.WriteLine("Parametrized constructor called" + " " + name);
    }

    //Copy Constructors
    public Constructors(Constructors e)
    {
        this.age= e.age;
    }
}
