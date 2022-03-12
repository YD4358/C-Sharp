//Input 3 numbers from command line argument and find greater between them using ternary operator.
using System;
namespace Assignments
{
    class CmdTern
    {
        public void trnCmd(string[] args)
        {
            
            int n1 = int.Parse(args[0]);
            
            int n2 = int.Parse(args[1]);
            
            int n3 = int.Parse(args[2]); 

            int max = (n1 > n2 && n1 > n2) ? n1 : (n2 > n3) ? n2 : n3;
            Console.WriteLine("Largest number is: "+ max);
        }
    }
}