//Write a program in C# to read n number of values in an array and display it in reverse order.
using System;
namespace Assignments
{
    class RevArr
    {
        public void rvar()
        {
            int i;
            int[] a= new int[100];
            
            Console.WriteLine("Input the number of elements to store in the array:");
            int n = int.Parse(Console.ReadLine());    
            Console.WriteLine("Enter {0} Elements: ",n);
            
            for(i=0;i<n;i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nReading The values stored in the array: ");
            
            for(i=0;i<n;i++)
	            Console.Write("{0} ",a[i]);
            
            Console.Write("\nDisplaying The values stored in the array in reverse Order: \n");
            
            for(i=n-1;i>=0;i--)
                Console.Write("{0} ",a[i]);
        }
    }
}