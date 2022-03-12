//Write a program to print all Armstrong numbers between given two intervals.

using System;
namespace Assignments
{
    class ArmInt
    {
        public void ArIt()
        {
            
            int r1, r2, temp, num, rem, count;
            double sum;
            Console.Write("Enter lower limit: ");
            r1 = int.Parse(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            r2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The Armstrong Numbers between {0} and {1} are:\n", r1, r2);
            for (int i = r1; i <= r2; i++)
            {
                count = 0;
                sum = 0;
                num = i;
                temp = i;
                while (temp > 0)
                {
                    temp /= 10;
                    count++;
                }
                while (num > 0)
                {
                    rem = num % 10;
                    sum += Math.Pow(rem, count);
                    num /= 10;
                }
                if (i == sum)
                    Console.Write("{0}\t", i);
            }
        }
    }
}