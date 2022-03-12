//Input a number from command line argument and check whether it is palindrome or not.
using System;
namespace Assignments
{
    public class CmdPalindrome
    {
        public void palinCmd(string[] args) 
        {
            int no, total = 0, t, rev;
            
            no = int.Parse(args[0]);
            t = no;
            while (no > 0) {
                rev = no % 10;
                total = (total * 10) + rev;
                no = no / 10;
            }
            if (t == total)
                Console.Write("The given number is Palindrome.");
            else
                Console.Write("The given number is not Palindrome");
        }
    }
}