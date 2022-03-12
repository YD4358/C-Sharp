//Write a C# program to store the information of one student using structure.
using System;
namespace Assignments
{
    class StrStud
    {
        struct Student
        {
            public int roll_number;
            public string name;
            public string c_class;
        }
        public void StudStr()
        {
            Student s1;
            Console.Write("Enter Student Roll No.: ");
            s1.roll_number = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            s1.name = Console.ReadLine();
            Console.Write("Enter Student Class: ");
            s1.c_class = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Roll no. "+s1.roll_number+" "+s1.name+" of class "+s1.c_class+" is marked Present");
        }
    }
}