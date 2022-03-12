//Demonstrate multiple inheritance with the use of interface with suitable example.
using System;
namespace Assignments
{
    interface addition{int add(int a, int b);}    
    interface substraction{int sub(int x, int y);}    
    interface multiplication{int mul(int r, int s);}    
    interface division{int div(int c, int d);}    
    class Calculation : addition, substraction, multiplication, division
    {    
        public int r1;    
        public int add(int a, int b){return r1 = a + b;}
        public int r2;    
        public int sub(int x, int y){return r2 = x - y;}    
        public int r3;    
        public int mul(int r, int s){return r3 = r * s;}    
        public int r4;    
        public int div(int c, int d){return r4 = c / d;}
    }     
    class Multiple
    {    
        public void mulInhrt()
        {    
            Calculation c = new Calculation();    
            c.add(8, 2);    
            c.sub(20, 10);    
            c.mul(5, 2);    
            c.div(20, 10);    
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");    
            Console.WriteLine("Addition: " + c.r1);    
            Console.WriteLine("Substraction: " + c.r2);    
            Console.WriteLine("Multiplication :" + c.r3);    
            Console.WriteLine("Division: " + c.r4);   
        }    
    }
}