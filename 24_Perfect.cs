//Write a C# program to check whether given number is perfect or not.(6, 28, 496, 8128 )
using System;
namespace Assignments
{
    class Perfec
    {
        public void perf()
        {
            int number,sum=0,n;
            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number;i++)
            {
                if (number % i == 0)
                {
                    sum=sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\nPerfect number");
            }
            else
            {
                Console.WriteLine("\nNot a perfect number");
            }
        }
    }
}
