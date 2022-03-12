//Write a program to demonstrate static constructor with proper example.
using System;
namespace Assignments
{
    class StConst
    {
        static DateTime globalStartTime;
        static StConst()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine(globalStartTime.ToLongTimeString());
        }
    }
}