//Write a program in C# to sort the given array in descending order.
using System;
namespace Assignments
{
    class SortArr
    {
        public void arrSrt()
        {
            int i, j, temp,n;
            int[] myArr = new int[100];
            Console.Write("Input the number of elements to be stored in the array: ");
            n = int.Parse(Console.ReadLine());  

            Console.WriteLine("Input {0} elements in the array: ",n);
            for(i=0;i<n;i++)
                myArr[i] = int.Parse(Console.ReadLine());
              
            Console.WriteLine("Stored Elements Are: ");
            for(i=0;i<n;i++)
                Console.Write("{0} ",myArr[i]);
            
            for(i=0; i<n; i++)
            {
                for(j=i+1; j<n; j++) 
                {
                    if(myArr[i] < myArr[j]) 
                    {
                        temp = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = temp;
                    }
                }
            }
            Console.Write("\nDescending order:\n");
            for(i=0; i<n; i++) {
                Console.Write("{0} ", myArr[i]);
            }
        }
    }
}