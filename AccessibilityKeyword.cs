using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibilityNameSpace;

public class AccessibilityKeyword
{
    private int age=4;
    public int birth = 22;
    protected string name="true";
    public void AgeFun()
    {
        Console.WriteLine(age);
    }
}
public class DeriveClass : AccessibilityKeyword
{
   
   public void Age()
    {
        Console.WriteLine(name);
    }
    
}


