//Write a program to convert 24-hour time format to 12-hour time format with am or pm appropriate.

using System;
namespace Assignments
{
    class Timee
    {
        public void tmctr()
        {
            
            Console.WriteLine("1. 12 Hrs\n2. 24Hrs\nSelect input time Format: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter time in 12Hrs format(hh.mm): ");
                    float tm = float.Parse(Console.ReadLine());
                    Console.WriteLine("Select: 1.am 2.pm");
                    int ap = int.Parse(Console.ReadLine());
                    if(ap == 1)
                        Console.WriteLine("24Hrs time is: "+tm+" Hrs");
                    if(ap == 2)
                        Console.WriteLine("24Hrs time is: "+(tm+12)+" Hrs");
                    break;
                
                case 2:
                    Console.WriteLine("Enter time in 24Hrs format(HH.MM): ");
                    tm = float.Parse(Console.ReadLine());
                    if(tm<12)
                        Console.WriteLine("\n12 Hrs time is: "+tm+" am");
                    else if(tm>12)
                        Console.WriteLine("\n12 Hrs time is: "+(tm-12)+" pm");
                    break;
            }
        }
    }
}