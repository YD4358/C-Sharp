//Write a program to assign suitable title (Miss, Mrs, Mr) to person. Take input one’s gender and material status if required.

using System;
namespace Assignments
{
    class Titl
    {
        public void titl()
        {
            
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("1.Male 2.Female");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello Mr."+name);
                    break;
                case 2:
                    Console.WriteLine("Are u Married ? (y || n)");
                    string married = Console.ReadLine();
                    if(married == "y" || married == "Y")
                        Console.WriteLine("Hello Mrs."+name);
                    else if(married == "n" || married == "N")
                        Console.WriteLine("Hello Miss."+name);
                    break;
                default:
                    System.Console.WriteLine("Enter Valid Selection");
                    break;
            }
        }
    }
}