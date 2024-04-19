// See https://aka.ms/new-console-template for more information
using System;
using ValueTypeNameSpace;
using ReferenceTypeNameSpace;
using MethodsNamespace;
using DelegationNamespace;
using PropertyNamespace;
using AccessibilityNameSpace;
using ConstructorNamespace;
class Program
{
    static void Main(string[] args)


    {
        // value type using struct
        Console.WriteLine("Value Type result using Struct");
        ValueTypePrac valueTypeObj1 ,valueTypeObj2 = new ValueTypePrac();
        valueTypeObj1.age = 10;
        valueTypeObj1.name = "zeeshan";
        
        valueTypeObj2 = valueTypeObj1;
        valueTypeObj1.age = 20;
        Console.WriteLine(valueTypeObj1.age +" "+ valueTypeObj1.name);
        Console.WriteLine(valueTypeObj2.age + " " + valueTypeObj2.name);

        //reference type using class
        Console.WriteLine("\nReference Type result using Class");

        ReferenceTypePrac  refTypeObJ2, refTypeObj1 = new ReferenceTypePrac();
       
        refTypeObj1.age = 10;
        refTypeObj1.name = "zeeshan";

        refTypeObJ2 = refTypeObj1;
        refTypeObj1.age = 20;
        Console.WriteLine(refTypeObj1.age + " " + refTypeObj1.name);
        Console.WriteLine(refTypeObJ2.age + " " + refTypeObJ2.name);


        Console.WriteLine("\nMethods");
        Methods.Show(2,"Ali");

        //By named argument we dont have to follow the sequence
        Console.WriteLine("\nMethods using Named Argument");
        Methods.Show(name:"Ali", age:2);

        //By optional argument set default value if no value is pass as argument
        Console.WriteLine("\nMethods using Optional Argument");
        Methods.Show(2);

        //Methods By using PassByValue
        Console.WriteLine("\nMethods using PassByValue");
        int value = 5;
        Methods.PassByValue(value);
        Console.WriteLine(value);

        //Methods By using PassByReference
        Console.WriteLine("\nMethods using PassByReference");
        int value2 = 5;
        Methods.PassByRef(ref value2);
        Console.WriteLine(value2);

        //Methods By using out keyword (Dont require initialization before passing it)
        Console.WriteLine("\nMethods using out Keyword");
        int value3 ;
        Methods.PassByOut(out value3);
        Console.WriteLine(value3);

        //Delegation
        Console.WriteLine("call method using Delegation");
        Calculation delObj = new Calculation(Delegation.Addtion);
     
        delObj(20, 10);
        delObj = Delegation.Subtraction;
        delObj(30, 10);

        //Property
        Console.WriteLine("getter setter using Property");
        Property prop = new Property();
        prop.Age = 5;
        Console.WriteLine(prop.Age);

        //Accessbility Keyword
        //private
        Console.WriteLine("Accessbility keyword Public, Private Protected");
        AccessibilityKeyword access=new AccessibilityKeyword();
        access.AgeFun();

        //public
        Console.WriteLine(access.birth);

        //protected
        DeriveClass derObj = new DeriveClass();
        derObj.Age();

        Console.WriteLine("\nConstructors");
        Constructors cons = new Constructors();

        //parametrized constructor
        Constructors cons1 = new Constructors("zeeshan");

        //Copy Constructor
        Constructors cons2 = new Constructors(cons1);
        Console.WriteLine("Copy COnstructor called \n"+cons1.age +" " + cons2.age);

        cons1.age = 20;
        Console.WriteLine("Copy COnstructor called \n" + cons1.age + " " + cons2.age);


    }
}
