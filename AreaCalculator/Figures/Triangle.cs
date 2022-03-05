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

            Sides[0] = a;
            Sides[1] = b;
            Sides[2] = c;
        }
        #endregion

        #region Properties
        public double[] Sides { get; }
        #endregion

        #region Private Methods
        protected override double GetArea()
        {
            return Sides.Sum() / 2;
        }
        protected bool IsRightTriangle()
        {
            int longestSideIndex = 0;
            for(int i = 0; i < Sides.Length; i++)
            {
                if(Sides[i] > Sides[longestSideIndex])
                {
                    longestSideIndex = i;
                }
            }

            double longestSqr = Math.Sqrt(Sides[longestSideIndex]);
            double otherSqrs = 0;
            for(int i = 0; i < Sides.Length; i++)
            {
                if (i != longestSideIndex)
                {
                    otherSqrs += Math.Sqrt(Sides[i]);
                }
            }
            return longestSqr == otherSqrs;
        }
        #endregion
    }
}
