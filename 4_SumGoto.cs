//Write a program to find sum of 1 to n numbers using goto statement.

using System;
namespace Assignments
{
    class SumGoto
    {
        public void sgt()
        {
            
            int counter=1;
            int n,temp;
            
            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            
            START:
            n=n+counter;
            counter++;
            if(counter<temp)
                goto START;
            Console.WriteLine(n);
        }
    }
}