//Write a program to print Fibonacci series up to n number of terms.

using System;
namespace Assignments
{
    class Fibo
    {
        public void fiboo()
        {
            int a, b, c;
            
            Console.WriteLine("Enter number of terms: ");
            int terms = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            c = 0;
            Console.WriteLine("Fibonacci terms: \n");
            for(int i=1; i<=terms; i++)
            {
                Console.WriteLine(c);
                a = b; 
                b = c;
                c = a + b; 
            }
        }
    }
}