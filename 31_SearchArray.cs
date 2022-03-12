//Write a program in C# to search given element in array.
using System;
namespace Assignments
{
    class SrchArr
    {
        public void arrSch()
        {
            int [] arr = new int[100];
            int n,key,i,flag=0;

            Console.Write("Enter Size: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Elements: ");
            for(i=0;i<n;i++)
                arr[i] = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Element to Search: ");
            key = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                if(arr[i]==key)
                {
                    flag =1;
                    Console.WriteLine("Element {0} Found at: {1}",key,(i+1));
                    break;
                }
            }
            if(flag == 0)
                System.Console.WriteLine("Element {0} is not in the Array",key);
        }
    }
}