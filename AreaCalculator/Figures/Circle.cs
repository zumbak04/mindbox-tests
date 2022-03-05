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

        #region Public Methods
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        #endregion
    }
}
