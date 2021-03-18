using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Amir Mohamed version 1
    /// </author>
    public class DistanceConverter
    {
        double miles;
        double feet;

        /// <summary>
        /// This is the constructor which intialises the class variable
        /// </summary>
        public DistanceConverter()
        {
            miles = 0;
            feet = 0;

            miles = GetMiles();
            feet = ConvertMilesToFeet();
            PrintResult();
        }

        /// <summary>
        /// This method returns the number or miles
        /// </summary>
        private double GetMiles()
        {
            Console.WriteLine("Please input the number of miles: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// This method turns miles to feet
        /// </summary>
        private double ConvertMilesToFeet()
        {
            return (miles * 5280);
        }

        /// <summary>
        /// This method prints Result of miles and feet
        /// </summary>
        private void PrintResult()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");
        }

    }
}
