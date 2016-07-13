using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task_Shape
{
    public class Rectangle : Shape
    {
        private double _a;
        private double _b;

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
        public double B
        {
            get { return _b; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _b = value;
            }
        }

        public override double GetPerimeter()
        {
            return 2*A + 2*B;
        }

        public override double GetArea()
        {
            return A*B;
        }

        public double GetDiagonal()
        {
            return Pow(A*A + B*B, 0.5);
        }
    }
}
