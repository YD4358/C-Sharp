//Demonstrate the difference between abstract class and interface.
using System;
using System.Threading;
namespace Assignments
{
    class Abst 
    {
        public void abstt()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "       Abstract Class", "        Interface"));
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "contains declaration and definition", "only a declaration."));
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "Multiple inheritance not achieved", "Multiple inheritance is achieved"));
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "contain constructor", "does not contain constructor"));
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "can contain static members", "does not contain static members"));
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "contain all access modifiers", "only contains public access modifier"));
            Thread.Sleep(1000);
            Console.WriteLine(String.Format("{0,-45} | {1,-10} ", "used to implement the core identity of class", "used to implement peripheral abilities of class"));
            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }
    }
}