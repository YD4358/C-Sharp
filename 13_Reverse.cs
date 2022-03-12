//Write a program to reverse the given number.

using System;
namespace Assignments
{
    class Reverse
    {
        public void rvr()
        {
            
            int  n, reverse=0, rem;           
            Console.Write("Enter a number: ");      
            n= int.Parse(Console.ReadLine());     
            while(n!=0)      
            {      
                rem=n%10;        
                reverse=reverse*10+rem;      
                n/=10;      
            }      
            Console.Write("Reversed Number: "+reverse);       
        }
    }
}