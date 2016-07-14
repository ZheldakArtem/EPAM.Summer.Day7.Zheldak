using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace Task_Shape
{
    /// <summary>
    /// The class describing a circle
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _radius = value;
            }
        }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
        public override double GetArea()
        {
            return PI * Radius * Radius;
        }
        public double GetDiamete()
        {
            return 2*Radius;
        }
    }
}
