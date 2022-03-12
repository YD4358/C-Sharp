//Write a c# program to convert given number in word. (357546  :  three five seven five four six )
using System;
namespace Assignments
{
    class WrdNum
    {
        public void numWrd()
        {
            
            int val, next, num_digits;
            int[] a = new int[10];
            string[] digits_words = {"zero","one","two","three","four","five","six","seven","eight","nine"};
            val = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + val);
            Console.Write("Number (words): ");
            next = 0;
            num_digits = 0;
            do 
            {
                next = val % 10;
                a[num_digits] = next;
                num_digits++;
                val = val / 10;
            } while (val > 0);
            num_digits--;
            for (; num_digits >= 0; num_digits--)
                Console.Write(digits_words[a[num_digits]] + " ");
        }
    }
}