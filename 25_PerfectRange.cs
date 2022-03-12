//Write a C# program to print all perfect numbers within given range.
using System;
namespace Assignments
{
    class PerfRange
    {
        public void perng()
        {
            int start, end, n, i, sum;
            Console.Write("Enter the starting range: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending range: ");
            end = int.Parse(Console.ReadLine());
            for(n=start;n<=end;n++)
            {
                sum=0;
                for(i=1;i<n;i++)
                {
                    if(n%i==0)
                        sum=sum+i;
                }
                if(n==sum)
                    Console.WriteLine(n);
            }
        }        
    }
}