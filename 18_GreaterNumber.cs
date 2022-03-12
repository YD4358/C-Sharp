//Write a program to find greater between given three numbers.

using System;
namespace Assignments
{
    class Great
    {
        public void grt()
        {
            
            int large;
            Console.Write("Enter first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third number : ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;

            Console.WriteLine("Largest number is {0}", large);
        }
    }
}