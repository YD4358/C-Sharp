//Write a program to check given character is vowel or consonant.

using System;
namespace Assignments
{ 
    public class VlCt
    {
        public void vocn()
        {
            
            char ch;
    
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());
    
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel.");  
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");            
            }
            else
            {
                Console.WriteLine("Invalid Character..!!");
            }
        }
    }
}