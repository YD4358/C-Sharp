/*Write a program to input electricity unit charge and calculate the total electricity bill according to the given condition:
    For first 50 units Rs. 0.50/unit
    For next 100 units Rs. 0.75/unit
    For next 100 units Rs. 1.20/unit
    For unit above 250 Rs. 1.50/unit
    An additional surcharge of 20% is added to the bill.*/
using System;
namespace Assignments
{
    class Billing
    {
        public void bill()
        {
            
            float cost, unit, sur, total;

            Console.Write("Enter the Electrictity Units Consumed: ");
            unit = float.Parse(Console.ReadLine());

            if (unit <= 50)
                cost = unit * 0.50f;
            else if (unit > 50 && unit <= 150)
                cost = 25 + ((unit - 50) * 0.75f);
            else if (unit > 150 && unit <= 250)
                cost = 100 + ((unit - 150) * 1.20f);
            else
                cost = 220 + ((unit - 250) * 1.50f);

            sur = cost * 0.20f;
            total = cost + sur;

            Console.WriteLine("The Electricity Bill is Rs. "+total);
        }
    }
}