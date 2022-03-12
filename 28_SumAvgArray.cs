//Write a program in C# to find the sum and average of all elements of the array.
using System;
namespace Assignments
{
    class SmAvgArr
    {
        public void smAvgAr()
        {
            float sum=0, avg=0;
            Console.Write("How many numbers you want to enter: ");
            int n = int.Parse(Console.ReadLine());
            float[] numbers = new float[n];
            Console.WriteLine("Enter {0} Elements: ",numbers.Length);
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = float.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : "+sum);
            Console.WriteLine("The Average is : "+avg);
        }
    }
}