//Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.
using System;
namespace Assignments
{
    static class StaticDemo
    {
        static int a = 1;
        static public void staic()
        {
            Console.WriteLine("{0}.In C#, static means something which cannot be instantiated",a);
        }
    }
}
