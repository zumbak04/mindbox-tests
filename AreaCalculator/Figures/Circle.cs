using System;

namespace AreaCalculator.Figures
{
    public class Circle : Figure
    {
        #region Constructors
        public Circle(float radius)
        {
            if(radius == 0)
            {
                throw new ArgumentOutOfRangeException("Радиус равен нулю");
            }
            else if(radius < 0)
            {
                throw new ArgumentOutOfRangeException("Радиус отрицательный");
            }

            Radius = radius;
        }
        #endregion

        #region Properties
        private float Radius { get; }
        #endregion

        #region Private Methods
        protected override double GetArea()
        {
            return Math.PI * Math.Sqrt(Radius);
        }
        #endregion
    }
}
