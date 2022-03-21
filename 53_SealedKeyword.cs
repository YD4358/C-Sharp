//Demonstrate the use of sealed keyword.(with class and methods)
using System;
namespace Assignments
{
    sealed class transaction
    {
        internal transaction()
        {
            Console.WriteLine("A sealed class is a class that cannot be inherited by any class but can be instantiated");
        }
    }
    class API
    {
        protected virtual void key() { Console.WriteLine("API Key =>  ewZt9AfBY5hTHQxX"); }
    }
    class ThirdParty : API
    {
        sealed protected override void key() { Console.WriteLine("Sealed Method allows you to derive from your class and prevent them from overriding specific virtual methods or properties"); }
    }
    class Hacker : ThirdParty
    {
        //protected override void key() { Console.WriteLine("Hacker Key"); }
    }
}