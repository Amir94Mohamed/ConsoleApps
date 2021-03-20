using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Here in this App it will be a Body Mass Index calculator which will calculate the users height and weight and health risks.
    /// </summary>
    /// <author>
    /// Student Amir Mohamed V1
    /// </author>
    public class BMI
    {

        private string unitType;
        private double feet;
        private double inches;
        private double stones;
        private double pounds;
        private double kg;
        private double metres;
        private double weightImperial;
        private double heightImperial;
        private double imperialBMI;
        private double metricBMI;

        /// <summary>
        /// Here it will output the heading
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------Body Mass Index Calculator------");
            Console.WriteLine("-----------By Amir Mohamed------------");
            Console.WriteLine("--------------------------------------");

        }
        /// <summary>
        /// Here in this method where the BMI will calculate itself.
        /// </summary>
        public void BMICalculation()
        {
            OutputHeading();
            SelectUnit();
            if (unitType == "1")
            {
                InputWeightInImperialUnit();
                InputHeightInImperialUnit();

                ImperialCalculation();
                BMIResults(imperialBMI);
            }
            else if (unitType == "2")
            {
                InputWeightInMetricUnit();
                InputHeightInMetricUnit();

                MetricCalculation();
                BMIResults(metricBMI);
            }
            PrintBAME();
        }
        /// <summary>
        /// In this method it will give the user options to enter his weight in metric unit
        /// </summary>
        private void InputWeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest KG");
            Console.WriteLine();

            Console.Write(" Enter your weight in KG > ");
            kg = Convert.ToDouble(Console.ReadLine());

        }
        /// <summary>
        /// In this method it will give the user options to enter his height in metric unit
        /// </summary>
        private void InputHeightInMetricUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest Metres");
            Console.WriteLine();

            Console.Write(" Enter your height in Metres > ");
            metres = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// In this method it will give the user options to enter his height in imperial unit
        /// </summary>
        private void InputHeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your height to the nearest feet and inches");
            Console.WriteLine();

            Console.Write(" Enter your height in feet > ");


            feet = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your height in inches > ");
            inches = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// In this method it will give the user options to enter his weight in imperial unit
        /// </summary>
        private void InputWeightInImperialUnit()
        {
            Console.WriteLine(" Please enter your weight to the nearest stones and pounds");
            Console.WriteLine();

            Console.Write(" Enter your weight in stones > ");
            stones = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your weight in pounds > ");
            pounds = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Here the user will choose which unit they would like to choose
        /// </summary>
        private void SelectUnit()
        {
            Console.WriteLine(" Please choose which unit you would like?");
            Console.WriteLine(" 1. Imperial unit ");
            Console.WriteLine(" 2. Metric unit ");
            Console.Write(" Please input your choice > ");
            unitType = Console.ReadLine();
        }
        /// <summary>
        /// Here it will do the imperial calculation
        /// </summary>
        private void ImperialCalculation()
        {
            double newPounds = stones * 14;
            weightImperial = pounds + newPounds;

            double newInches = feet * 12;
            heightImperial = inches + newInches;

            imperialBMI = (weightImperial * 703) / (heightImperial * heightImperial);
        }
        /// <summary>
        /// here it will do the metric calculation
        /// </summary>
        private void MetricCalculation()
        {
            metricBMI = (kg) / (metres * metres);
        }
        /// <summary>
        /// here the BMI results appear and it tells the user if they are underweight or overweight
        /// </summary>
        /// <param name="BMI"></param>
        private void BMIResults(double BMI)
        {
            BMI = Math.Round(BMI, 2);
            if (BMI <= 18.5)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are underweight! ");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are normal! ");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are overweight! ");
            }
            else if (BMI >= 30 && BMI <= 34.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 1! ");
            }
            else if (BMI >= 35 && BMI <= 39.9)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 2! ");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine(" Your BMI result is " + BMI);
                Console.WriteLine();
                Console.WriteLine(" You are obese class 3! ");
            }
        }
        /// <summary>
        /// here in this method it will print the BAME. 
        /// </summary>
        private void PrintBAME()
        {
            Console.WriteLine("If you are Black, Asian or other ethnic groups,\n\r" +
                "you have a higher risk.\n\r\n\r" +
                "Adults 23 or more are at increased risk.\n\r" +
                "Adults 27.5 or more are at high risk.9\n\r\n\r");
        }

    }
}