//Write a program to enter student marks and calculate percentage and grade.

using System;
namespace Assignments
{
    class student
    {
        public void percnt()
        {
            
            int marks1, marks2, marks3, total;
            float percentage;
            string n; 
            
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();
            
            Console.WriteLine("Enter Science Marks : ");
            marks1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Maths Marks : ");
            marks2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter English Marks :");
            marks3 = int.Parse(Console.ReadLine());
            
            total = marks1 + marks2 + marks3;
            
            percentage = total / 3.0f;
            
            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);

            if(marks1<35 || marks2<35 || marks3<35)
                System.Console.WriteLine("You are Failed");
           
            if(marks1>35 && marks2>35 && marks3>35)
            {
                if (percentage <= 35)
                {
                    Console.WriteLine("Grade is F");
                }
                else if (percentage >= 34 && percentage <= 39)
                {
                    Console.WriteLine("Grade is D");
                }
                else if (percentage >= 40 && percentage <= 59)
                {
                    Console.WriteLine("Grade is C");
                }
                else if (percentage >= 60 && percentage <= 69)
                {
                    Console.WriteLine("Grade is B");
                }
                else if (percentage >= 70 && percentage <= 79)
                {
                    Console.WriteLine("Grade is B+");
                }
                else if (percentage >= 80 && percentage <= 90)
                {
                    Console.WriteLine("Grade is A");
                }
                else if (percentage >= 91)
                {
                    Console.WriteLine("Grade is A+");
                }
                System.Console.WriteLine("You are Passed");
            }
        }
    }
}