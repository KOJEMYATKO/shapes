using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeslib
{
    public class Class1
    {
        /// <summary>Площадь треугольника</summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона Б</param>
        /// <param name="c">Сторона C</param>
        /// <returns></returns>
        public static double triangleSide(double a, double b, double c)
        {
            double p = (a + b + c) /2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public static double triangleAngle(double a, double b, double c)
        {
            double S = a * b * Math.Sin(c) /2;
            return S;
        }
        public static double Rectangle(double a, double b)
        {
            double S = a * b;
            return S;
        }
        public static double Circle(double rad)
        {
            double S = rad * rad * Math.PI;
            return S;
        }
    }
}
