using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio2_Area_of_a_Circle
{
    public class Circle
    {
        public static double GetArea(double radius)
        {
            double area = Math.Round(Math.PI * Math.Pow(radius, 2.0), 2);
            return area;
        }

        public static double GetCircumference(double radius)
        {
            double circumference = Math.Round((2 * Math.PI * radius), 2);
            return circumference;
        }

        public static double GetDiameter(double radius)
        {
            double diameter = Math.Round((2 * radius), 2); ;
            return diameter;
        }

    }
}
