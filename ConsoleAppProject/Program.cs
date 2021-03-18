using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.Helpers;


namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Amir Mohamed 18/03/2021
    /// </summary>

    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            //Console.Beep();
            Console.WriteLine();
            Console.WriteLine(GetHeading("Convert Distances"));

            DistanceConverter converter = new DistanceConverter();

        }

        private static string GetHeading(string title)
         {
             return "--------------------------------------------\n"
                      + "\t\t" + title
                      + "\n\t\tAmir Mohamed" +
                    "\n---------------------------------------------\n";
         }


    }
}
