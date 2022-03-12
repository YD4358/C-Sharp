//Take Account as abstract class. Make saving a/c and current a/c as its child. Make hierarchical inheritance between them.
using System;
namespace Assignments
{
    abstract class Account
    {
        public abstract void Acc();
    }
    class SavingAcc : Account
    {
        public override void Acc(){Console.WriteLine("Saving Account Class");}
    }
    class CurrentAccount : Account
    {
        public override void Acc(){Console.WriteLine("Current Account Class");}
    }
}