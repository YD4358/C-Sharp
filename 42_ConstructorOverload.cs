//Write a program which will demonstrate constructor overloading. Use default, paratermised and copy constructor.
using System;
namespace Assignments
{
    class Constr 
    {  
        string ss;
        internal Constr()
        {
            Console.WriteLine("Default");
        }
        internal Constr (string strr)
        {
            ss = strr;
            Console.WriteLine(ss);
        }
        internal Constr(Constr c1)
        {
            ss = c1.ss;
            Console.WriteLine("Copied "+c1.ss);
        }
    }
}