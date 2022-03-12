//Write a program to calculate sum of all even numbers up to given number.

using System;
namespace Assignments
{
    class SumOfEvn
    {
        public void smevn()
        {
            
            int sum=0;
            Console.WriteLine("Enter upper limit: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=2; i<=n; i+=2)
            {
                sum += i;
            }

            Console.WriteLine("Sum of all even number between 1 to {0} = {1}", n, sum);

        }
    }
}