//Demonstrate the use of all access specifiers with suitable example.
using System;
namespace Assignments
{
    class AccSpec
    {
        public string name = "Public Name";
        protected string userName = "Protected UserName";
        private string _Password = "Private Email";
        internal string uniqueID = "Internal Unique Id";
        protected internal string DateOfBirth = "Protected Internal DOB";
        public void infoo()
        {
            Console.WriteLine("By default members of classes are Private.\nBy default classes are Internal.\nBy default namespaces are Public but we are not supposed to specify the public keyword.");
            Console.WriteLine("------------------------------------------------------------------------\n");

            Console.WriteLine("Public: Members and variables can be accessed from any class and any assembly.\n{0}",name);
            Console.WriteLine("Protected: Members and variables can be accessed within its class and derived class of the same assembly.\n{0}",userName);
            Console.WriteLine("Private: Members and variables can be accessed within the class only.\n{0}",_Password);
            Console.WriteLine("Internal: Members and variables can be accessed from anywhere within the same assembly.\n{0}",uniqueID);
            Console.WriteLine("Protected Internal: Members can be accessed anywhere in the same assembly and also accessible by inheriting that class. It can be accessible outside the assembly in the derived class only. Protected Internal member works as Internal within the same assembly and works as Protected outside the assembly.");
        }        
    }
}