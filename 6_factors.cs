//Write a program to find all factors of given number.

using System;
namespace Assignments
{
    class factr
    {
        public void ftr() 
        {
            
            Console.Write("Enter the value of number:");
            int number = int.Parse(Console.ReadLine());
            int factor;
            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.Write(factor + " ");
                }
            }
        }
    }
}