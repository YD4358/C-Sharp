//Write down a menu driven program using switch to convert various distance from one unit to other.
using System;
namespace Assignments
{
    class DisCon
    {
        public void distcon()
        {
            lbll:
            Console.Clear();
            Console.WriteLine("Select \n1.Imperial Units \n2.Astronomical Distance");
            int sgs = int.Parse(Console.ReadLine());
            if(sgs == 1)
            {
                Console.WriteLine("Enter \n1.Feet to Yard \n2.Inch to feet");
                int ddd = int.Parse(Console.ReadLine());
                switch (ddd)
                {
                    case 1:
                        Console.WriteLine("Enter Feets: ");
                        float ft = int.Parse(Console.ReadLine());
                        Console.WriteLine("Yards: "+(ft*0.33));
                        break;
                    case 2:
                        Console.WriteLine("Enter Inch: ");
                        float ic = int.Parse(Console.ReadLine());
                        Console.WriteLine("Feets: "+(ic*0.083));
                        break;
                    default:
                        System.Console.WriteLine("No Valid selection");
                        break;
                }
            }
            else if(sgs==2)
            {
                Console.WriteLine("Enter \n1.Parsec to LightYear \n2.RedShift(Z) to LightYear");
                int ddd = int.Parse(Console.ReadLine());
                switch (ddd)
                {
                    case 1:
                        Console.WriteLine("Enter Parsec: ");
                        float pc = int.Parse(Console.ReadLine());
                        Console.WriteLine("LightYears: "+(pc*3.261564));
                        break;
                    case 2:
                        Console.WriteLine("Enter RedShift(Z): ");
                        long rc = int.Parse(Console.ReadLine());
                        Console.WriteLine("LightYears: "+(rc*13770322267));
                        break;
                    default:
                        System.Console.WriteLine("No Valid selection");
                        break;
                }
            }
            Console.WriteLine("For continue press 1\nFor Exit press 0");
            int chsc = int.Parse(Console.ReadLine());
            if(chsc == 1)
                goto lbll;
            else
                Console.WriteLine("Have a Good Day");
        }
    }
}