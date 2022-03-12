//Write a program to find table of given number.

using System;
namespace Assignments
{
    class Table
    {
        public void Tbl()
        {
            
            int num;
            Console.Write("Enter the Number :");
            num = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
            }
        }
    }
}