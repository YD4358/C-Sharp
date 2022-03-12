//Input one matrix and print its transpose.
using System;
namespace Assignments
{
    class TranspMat
    {
        public void matTrans()
        {
            int i, j, m, n;
            int[, ] arr1 = new int[30, 30];
            int[, ] arr2 = new int[30, 30];

            Console.Write("Matrix Rows: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Matrix Columns: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter The Elements: ");
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++) 
                {
                    Console.Write("\n[{0}],[{1}] : ", i, j);
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("\n\nMatrix before Transpose:\n");
            for (i = 0; i < m; i++) 
            {
                //Console.Write("\n");
                for (j = 0; j < n; j++)
                Console.Write("{0}\t", arr1[i, j]);
                System.Console.WriteLine("");
            }

            for (i = 0; i < n; i++) 
            {
                for (j = 0; j < m; j++) 
                {
                    arr2[i,j] = arr1[j,i];
                }
            }

            Console.WriteLine("\n\nMatrix after Transpose: ");
            for (i = 0; i < n; i++) 
            {
                //Console.Write("\n");
                for (j = 0; j < m; j++) 
                    Console.Write("{0}\t", arr2[i, j]);
                System.Console.WriteLine(" ");
            }
        }
    }
}