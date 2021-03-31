using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will allow the user to input a distance as a unit (fromUnit) and
    /// it will calculate and output the distance (toUnit).
    /// </summary>
    /// <author>
    /// Amir Mohamed V1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        /// <summary>
        /// Here is the Distance Converter which chooses the from unit and to unit
        /// </summary>
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;

        }

        /// <summary>
        /// Here this method will change the Distance from Miles to Feet.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the FROM distance unit : ");
            toUnit = SelectUnit(" Please select the TO distance unit : ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Enter the number of {fromUnit} : ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Here it will calculate the distance
        /// </summary>
        private void CalculateDistance()
        {
            CalculationMilesToFeet();
            CalculationMetresToMiles();
            CalculationFeetToMetres();
        }

        /// <summary>
        /// here is the calculation method which will be used in the calculate distance
        /// </summary>
        private void CalculationMilesToFeet()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
        }

        private void CalculationMetresToMiles()
        {
            if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
        }

        private void CalculationFeetToMetres()
        {
            if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// Here the user can choose which unit they would like to choose
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// here the user will execute the choice of what unit they would like to choose
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }
        /// <summary>
        /// here the units will be displayed for the user to choose from
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            if (choice != FEET)
            {
                Console.WriteLine(" Please, choose the correct choice. ");
                return choice;
            }
            if (choice != METRES)
            {
                Console.WriteLine(" Please, choose the correct choice. ");
                return choice;
            }
            if (choice != MILES)
            {
                Console.WriteLine(" Please, choose the correct choice. ");
                return choice;
            }
            return choice;
        }

        /// <summary>
        /// Here the user can input any distance
        /// </summary>

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Here when the programmed is running it will output the Distance
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
                $" is {toDistance} {toUnit}!");
        }

        /// <summary>
        /// Here it will output the heading and the prompt
        /// </summary>
        /// <param name="prompt"></param>
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\n------------Distance Converter------------");
            Console.WriteLine("\n------------By Amir Mohamed---------------");
            Console.WriteLine("\n------------------------------------------");
        }

    }
}