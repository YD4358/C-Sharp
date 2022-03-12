//Input a square matrix and find the sum of diagonal elements.
using System;
namespace Assignments
{
    class DiagSumMat
    {
        public void dgsmat()
        {
            int i,j,sum=0,n,m=0;
            int[,] arr1 = new int[50,50];	 
            
            Console.Write("Input the size of the square matrix : ");
            n = int.Parse(Console.ReadLine());

            m=n;
            
            Console.Write("Input elements in the matrix :\n");
            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.Write("[{0}],[{1}] : ",i,j);
                    arr1[i,j]=int.Parse(Console.ReadLine());
                }
            }  
            Console.Write("The matrix is :\n");
            for(i=0;i<n;i++)
            {
                for(j=0;j<n ;j++)
                    Console.Write("{0}  ",arr1[i,j]);
                
                Console.Write("\n");
            }

            for(i=0;i<n;i++)
            {
                m=m-1;
                for(j=0;j<n ;j++)
                {
                    if (j==m)
                        sum= sum+arr1[i,j];
                
                }
            }
            Console.Write("Sum of Diagonal elements is: {0}\n",sum);
        }
    }
}