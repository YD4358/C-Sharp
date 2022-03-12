//Write a program to calculate profit or loss.

using System;
namespace Assignments
{
    class ProLos
    {
        public void PL()
        {
            int cp,sp, res; 
            Console.Write("Input Cost Price: ");  
            cp=int.Parse(Console.ReadLine()); 
            Console.Write("Input Selling Price: ");  
            sp= int.Parse(Console.ReadLine());  
            
            if(sp>cp) 
            {  
                res = sp-cp;  
                Console.Write("\nprofit of amount : {0}\n", res);  
            }  
            else if(cp>sp)  
            {  
                res = cp-sp;  
                Console.Write("\nloss of amount : {0}\n", res);  
            }  
            else   
            {  
                Console.Write("\nno profit no loss\n");  
            } 
        }
    }
}