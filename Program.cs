// See https://aka.ms/new-console-template for more information
using System;
using ValueTypeNameSpace;
using ReferenceTypeNameSpace;
class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Value Type result using Struct");
        ValueTypePrac valueTypeObj1 ,valueTypeObj2 = new ValueTypePrac();
        valueTypeObj1.age = 10;
        valueTypeObj1.name = "zeeshan";
        
        valueTypeObj2 = valueTypeObj1;
        valueTypeObj1.age = 20;
        Console.WriteLine(valueTypeObj1.age +" "+ valueTypeObj1.name);
        Console.WriteLine(valueTypeObj2.age + " " + valueTypeObj2.name);

        Console.WriteLine("\nReference Type result using Class");

        ReferenceTypePrac  refTypeObJ2, refTypeObj1 = new ReferenceTypePrac();
       
        refTypeObj1.age = 10;
        refTypeObj1.name = "zeeshan";

        refTypeObJ2 = refTypeObj1;
        refTypeObj1.age = 20;
        Console.WriteLine(refTypeObj1.age + " " + refTypeObj1.name);
        Console.WriteLine(refTypeObJ2.age + " " + refTypeObJ2.name);


    }
}
