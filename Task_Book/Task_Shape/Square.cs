using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task_Shape
{
    public class Square : Shape
    {
        private double _a;

        public double A
        {
            get { return _a; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _a = value;
            }
        }

        public Square()
        {
        
        }
        public Square(double a)
        {
            A = a;
        }

        public override double GetArea()
        {
            return A*A;
        }
        public override double GetPerimeter()
        {
            return A*4;
        }
        public double GetDiagonal()
        {
            return Pow(2, 0.5)*A;
        }
    }
}
