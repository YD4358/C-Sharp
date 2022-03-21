//Write a program which will demonstrate the function overriding.
using System;
namespace Assignments
{
    internal class Girl 
    {
        string name = Console.ReadLine() ;
        public virtual void showdata()
        {
            Console.WriteLine("Name Before Marriage : " + name);
        }
    }
    internal class Married : Girl {

        string s = Console.ReadLine();
        public override void showdata()
        {
            Console.WriteLine("Name After Marriage : " + s);
        }
    }
}