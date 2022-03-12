//Write a program to find sum of all digits in given number.

using System;
namespace Assignments
{
    class DgtSum
    {
        public void sumDgt()
        {
            
            Console.Write("Enter the Number : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;
           
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            
            Console.WriteLine("The Sum of Digits is : "+sum);
        }
    }
}