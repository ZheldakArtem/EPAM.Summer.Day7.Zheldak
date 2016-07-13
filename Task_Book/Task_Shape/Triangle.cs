using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Math;

namespace Task_Shape
{

    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (!ValidationEventArgs(value, _b, _c))
                    throw new ArgumentException();
                _a = value;
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {
                if (!ValidationEventArgs(_a, value, _c))
                    throw new ArgumentException();
                _b = value;
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (!ValidationEventArgs(_a, _b, value))
                    throw new ArgumentException();
                _c = value;
            }
        }

        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            double S = p * (p - A) * (p - B) * (p - B);

            return Pow(S, 0.5);
        }
        private bool ValidationEventArgs(double a, double b, double c)
        {

            return (a < b + c) && (a > b - c) && (b < a + c) && (b > a - c) && (b > a - c) && (c < a + b) &&
                    (c > a - b);
        }
    }
}
