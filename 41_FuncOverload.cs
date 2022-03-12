//Write a program which will demonstrate function overloading. Use minimum 3 functions.
using System;
namespace Assignments
{
    class FuncOver
    {
        void fun()
        {
            Console.WriteLine("No Value Provided");
        }
        void fun(int x, int y)
        {
            Console.WriteLine("sum of {0} and {1} is {2}", x, y, (x + y));
        }
        void fun(float x, float y)
        {
            Console.WriteLine("sum of {0} and {1} is {2}", x, y, (x + y));
        }
        void fun(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }

        public void overFun()
        {
            fun();
            fun(5,4);
            fun(9.3f, 8.6f);
            fun("String");
        }
    }
}