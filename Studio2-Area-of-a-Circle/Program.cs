﻿using System;

namespace Studio2_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double pi = 3.14;
            double radius;
            double area;

            Console.WriteLine("Enter a radius:");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = pi * Math.Pow(radius, 2.0);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
        }
    }
}
