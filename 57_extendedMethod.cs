//Write a program to implement the concept of extended method.
using System;
using System.Threading;
namespace Assignments
{
    internal class Android
    {
        bool cam,loc,sen;
        internal bool camera{get{return cam;} set{cam = value;}}
        internal bool location{get{return loc;} set{loc = value;}}
        internal bool sensors{get{return sen;} set{sen = value;}}
        internal void Version()
        {
            System.Console.WriteLine("Welcome To Android");
            System.Console.WriteLine("Current Android Version is: ");
            Thread.Sleep(100);
            System.Console.WriteLine(" *   ** ");
            Thread.Sleep(100);
            System.Console.WriteLine("**  *  *");
            Thread.Sleep(100);
            System.Console.WriteLine(" *  *  *");
            Thread.Sleep(100);
            System.Console.WriteLine(" *    * ");
            Thread.Sleep(100);
            System.Console.WriteLine(" *   *  ");
            Thread.Sleep(100);
            System.Console.WriteLine(" *  *   ");
            Thread.Sleep(100);
            System.Console.WriteLine("*** ****");           
        }
    }
    internal static class Xiaomi
    {
        internal static void function(this Android api)
        {
            api.Version();
            System.Console.Write("Press Enter to Continue:");
            Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("| Press '1' to allow access.|\n| Press'0' to Deny Access.|");
            System.Console.WriteLine("-----------------------------------------------------");
            System.Console.WriteLine("Allow Access to Camera");
            api.camera = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("Allow Access to location");
            api.location = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("Allow Access to Sensors");
            api.sensors = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("{0} {1} {2}",api.camera,api.location,api.sensors);
            Thread.Sleep(5000);
            version();
        }
        internal static void version()
        {
            Android api = new ();
            Console.Clear();
            System.Console.WriteLine("Camera Access Status: {0}",api.camera);
            Thread.Sleep(1000);
            System.Console.WriteLine("location Access Status: {0}",api.location);
            Thread.Sleep(1000);
            System.Console.WriteLine("Sensors Access Status: {0}",api.sensors);
            Thread.Sleep(2000);
            Console.Clear();
            if (api.camera && api.location && api.sensors)
            {
                System.Console.WriteLine("Welcome to MIUI");
                System.Console.WriteLine("Current Version is: ");
                System.Console.WriteLine("*   * ***");
                Thread.Sleep(100);
                System.Console.WriteLine("** **  * ");
                Thread.Sleep(100);
                System.Console.WriteLine("* * *  * ");
                Thread.Sleep(100);
                System.Console.WriteLine("*   * ***");
            }
            else{System.Console.WriteLine("Access denied");}
        }
    }
}