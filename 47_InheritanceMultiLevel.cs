/*Write a C# program to demonstrate multilevel inheritance. Base class – bird, middle class – flying birds, 
  child class – any bird. Use appropriate methods in related class. */
using System;
namespace Assignments
{
    class Bird
    {
        public Bird(){System.Console.WriteLine("Bird Class");}
    }
    class FlyingBird : Bird
    {
        public FlyingBird(){System.Console.WriteLine("FlyingBird Class");}
    }
    class Eagle : FlyingBird
    {
        public Eagle(){System.Console.WriteLine("Eagle Class");}
    }
}