/*Declare a class name ‘A’ with some methods and one parameterised constructor. 
  \nDerive another class ‘B’ from ‘class A’. 
  \nIn class B have some methods and constructor. 
  \nDemonstrate how base class parameterised constructor gets call from child class constructor. */
using System;
namespace Assignments
{
    class A
    {
        void A_Method(){Console.WriteLine("In A Method");}
        public A(char a){Console.WriteLine("This is the A Constructor "+a);}
    }
    class B : A
    {
        void B_Method(){Console.WriteLine("In B Method");}
        public B(char b):base(b){Console.WriteLine("This is the B Constructor "+b);}
    }
}