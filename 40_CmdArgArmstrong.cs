//Input a number from command line argument and check it is Armstrong or not.
using System;
namespace Assignments
{
   class CmdArmstrong
   {
       public void armCmd(string[] args)
       {
           int num, temp, n, rem, count=0;
           double sum = 0;
           
           num = int.Parse(args[0]);
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