//Write a C# program to convert given number in word form . (147 : one hundred forty seven)

using System;
namespace Assignments
{
    class NunWrd
    {
        public void wrdNm()
        {
            
            string[] unit = {"ZERO" ,"ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
            string[] tens = {"TEN","ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINTEEN" };
            string[] hund = { "ZERO","TEN", "TWENTY", "THIRTY", "FOURTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINTY" ,"HUNDRED"};

            System.Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int temp;
            if (number <= 99999) 
            {
                if (number == 0) 
                    Console.Write(" " + unit[number]);

                if (number >= 1000) 
                {
                    temp = number / 1000;
                    if (number % 10000 == 0) 
                    {
                        temp = temp / 10;
                        Console.Write(tens[temp - 1] + " THOUSAND ");
                        return;
                    }
                    if (number % 1000 == 0) 
                    {
                        Console.Write(unit[temp] + " THOUSAND ");
                        return;
                    }
                    if (temp >= 10 && temp <= 19) 
                    {
                        temp = temp % 10;
                        Console.Write(" "+ tens[temp] + " ");
                        temp = -1;
                    }
                    if (temp >= 20 && temp <= 99) 
                    {
                        int i = temp / 10;
                        temp = temp % 10;
                        Console.Write(" " + hund[i] + " ");
                    }
                    if (temp > 0 && temp <= 9) 
                    {
                        Console.Write(" "+ unit[temp] +" ");
                    }
                    Console.Write( " THOUSAND ");
                    number = number % 1000;
                }
                if (number >= 100) 
                {
                    temp = number / 100;
                    if (number % 100 == 0) 
                    {
                        Console.Write(unit[temp] + " HUNDRED ");
                        return;
                    }
                    number = number % 100;
                    Console.Write(unit[temp] + " HUNDRED AND ");
                }
                if (number >= 10 && number < 20) 
                {
                    temp = number % 10;

                    Console.Write(" " + tens[temp]);
                }
                if (number > 19 && number <= 100) 
                {
                    temp = number / 10;
                    if (number == 100) 
                    {
                        Console.Write(" " + hund[temp - 1] + " ");
                        return;
                    }
                    number = number % 10;
                    Console.Write(" " + hund[temp] + " ");
                }
                if (number < 10) 
                {
                    if (number != 0) 
                        Console.Write(" "+ unit[number]);
                }
            } 
            else 
            {
                Console.WriteLine("Enter a small number");
            }
        }
    }
}