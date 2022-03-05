using System;
using System.Linq;

namespace AreaCalculator.Figures
{
    public class Triangle : Figure
    {
        #region Constructors
        public Triangle(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentOutOfRangeException("Одна из сторон равна нулю");
            }
            else if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("Одна из сторон отрицательная");
            }

            Sides = new double[3];
            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;
        }
        #endregion

        #region Properties
        public double[] Sides { get; }
        #endregion

        #region Public Methods
        public override double GetArea()
        {
            double semiPer = Sides.Sum() / 2;
            return Math.Sqrt(semiPer * (semiPer - Sides[0]) * (semiPer - Sides[1]) * (semiPer - Sides[2]));
        }
        public bool IsRightTriangle()
        {
            Array.Sort(Sides);

            return Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2);
        }
        #endregion
    }
}
