//Write a program which will demonstrate the use of static keyword with variables, methods, and constructor.
using System;
namespace Assignments
{
    class StaticDemo
    {
        static int a = 5;
        public void staic()
        {
            Console.WriteLine("In C#, static means something which cannot be instantiated. You cannot create an object of a static class and cannot access static members using an object.");
            a=10;
            Console.WriteLine(a);
        }
    }
}
