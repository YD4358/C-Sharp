//Write a program to check given number is even or odd.

using System;
namespace Assignments
{
    class EvnOdd
    {
        public void evnOd()
        {
            
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Number is an Even Number");
            }
            else
            {
                Console.Write("Number is an Odd Number");
            }
        }
    }
}