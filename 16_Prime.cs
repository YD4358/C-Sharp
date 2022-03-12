//Write a program to print all prime numbers between given two intervals.

using System;
namespace Assignments
{
    class PrimeNo
    {
        public void prmNo()
        {
            
            Console.Write("enter first intervals: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("enter Second intervals: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("prime no present in between {0} and {1}:",number1,number2);
            for(int i=number1+1;i<number2;i++)
            {
                int flag=0;
                for(int j=2;j<=i/2;++j)
                { 
                    if(i%j==0)
                    {
                        flag=1;
                        break;
                    }
                }
                if(flag==0)
                    Console.WriteLine(i);
            }
        }
    }
}