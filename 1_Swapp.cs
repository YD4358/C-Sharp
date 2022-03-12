//Write a program to swap given two numbers.

using System;
namespace Assignments
{
    class Swapp
    {
        public void swp()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : \n");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : \n");
            number2 = int.Parse(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Write("After Swapping : \n");
            Console.Write("\nFirst Number : "+number1);
            Console.Write("\nSecond Number : "+number2);
        }
    }
}