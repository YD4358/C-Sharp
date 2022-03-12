//Write a program to find given number is Armstrong or not.

using System;
namespace Assignments
{
   class Armstrong
   {
       public void arm()
       {
           int num, temp, n, rem, count=0;
           double sum = 0;
           Console.Write("Enter a number: ");
           num = int.Parse(Console.ReadLine());
           n = num;
           temp = num;
           while(temp > 0)
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
           if (n == sum)
               Console.WriteLine("\n{0} is an Armstrong Number", n);
           else
               Console.WriteLine("\n{0} is not an Armstrong Number", n);
       }
   }
}