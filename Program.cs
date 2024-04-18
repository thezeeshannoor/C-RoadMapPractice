// See https://aka.ms/new-console-template for more information
using System;
using ValueTypeNameSpace;
class Program
{
    static void Main(string[] args)
    {
        ValueTypePrac valueTypeObj1 ,valueTypeObj2 = new ValueTypePrac();
        valueTypeObj1.age = 10;
        valueTypeObj1.name = "zeeshan";
        
        valueTypeObj2 = valueTypeObj1;
        valueTypeObj1.age = 20;
        Console.WriteLine(valueTypeObj1.age +" "+ valueTypeObj1.name);
        Console.WriteLine(valueTypeObj2.age + " " + valueTypeObj2.name);
    }
}
