using System;

namespace Studio2_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double mpg;
            double amtOfGas;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            double result; // input when parsed 
            //radius = double.Parse(input);

            if (input == "" || !double.TryParse(input, out result)) //in blank or NOT double
            {
                Console.WriteLine("Invalid radius - exiting program. ");
                Environment.Exit(0);
            }

            radius = double.Parse(input);
            while (radius < 0)
            {
                Console.WriteLine("Please enter a valid radius");
                input = Console.ReadLine();
                radius = double.Parse(input);

            }

            //double radius = double.Parse(input);
            Console.WriteLine("Enter miles per gallon of your car:");
            input = Console.ReadLine();
            mpg = double.Parse(input);

            amtOfGas = Math.Round((Circle.GetCircumference(radius)/mpg),2);

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.GetArea(radius));
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + Circle.GetCircumference(radius));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + Circle.GetDiameter(radius));
            Console.WriteLine("Amount of gas consumed to drive " + Circle.GetCircumference(radius) + " is: " + amtOfGas + ".");

        }

        private static bool IsNaN(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
