using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task_Shape
{
    public class Circle : Shape
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _r = value;
            }
        }

        public Circle(double r)
        {
            R = r;
        }

        public override double GetPerimeter()
        {
            return 2 * PI * R;
        }
        public override double GetArea()
        {
            return PI * R * R;
        }
        public double GetDiamete()
        {
            return 2*R;
        }
    }
}
