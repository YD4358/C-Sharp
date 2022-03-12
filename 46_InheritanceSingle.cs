/*Write a C# program which will demonstrate the single inheritance. Take base class as Bird and child class as parrot. 
  Write and inherit the appropriate methods */
using System;
namespace Assignments
{
    class bird
    {
        internal bird(){Console.WriteLine("Bird Class");}
    }
    class parrot : bird
    {
        internal parrot(){Console.WriteLine("parrot Class");}
    }
}