using System;

namespace Studio2_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double area;
            double circumference;
            double diameter;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = Math.PI * Math.Pow(radius, 2.0);
            circumference = 2 * Math.PI * radius;
            diameter = 2 * radius;
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);
        }
    }
}
