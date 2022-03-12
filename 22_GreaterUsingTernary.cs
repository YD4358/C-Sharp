//Find the greater between given 3 numbers using ternary operator.
using System;
namespace Assignments
{
    class GrTern
    {
        public void GTern()
        {
            Console.Write("Enter First Number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int n3 = int.Parse(Console.ReadLine());           
            int max = (n1 > n2 && n1 > n2) ? n1 : (n2 > n3) ? n2 : n3;
            Console.WriteLine("Largest number is: "+ max);
        }
    }
}