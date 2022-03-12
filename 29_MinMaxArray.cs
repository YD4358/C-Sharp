//Write a program in C# to find maximum and minimum element in an array.
using System;
namespace Assignments
{
    class MinMaxArr
    {
        public void mimxar()
        {
            int[] arr1= new int[100];
            int i, mx, mn, n;
            Console.Write("Input the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());  
        
            Console.WriteLine("Input {0} elements in the array: ",n);
            for(i=0;i<n;i++)
                arr1[i] = int.Parse(Console.ReadLine());  


            mx = arr1[0];
            mn = arr1[0];

            for(i=1; i<n; i++)
            {
                if(arr1[i]>mx)
                    mx = arr1[i];
                if(arr1[i]<mn)
                    mn = arr1[i];
            }
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
        }
    }
}