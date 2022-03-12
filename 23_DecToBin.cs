//Write a C# program to convert decimal number to binary.
using System;
namespace Assignments
{
    class DecToBin
    {
        public void dbn()
        {
            Console.Write("Enter the Decimal Number: ");
            int number = int.Parse(Console.ReadLine());
            
            string Result = string.Empty;
            for (int i = 0; number > 0; i++)
            {
                Result = number % 2 + Result;
                number = number / 2;
            }
            Console.WriteLine("Binary Represenation of the given Number is: "+Result);
        }
    }
}