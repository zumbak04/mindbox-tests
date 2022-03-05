using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator.Figures;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void CircleGetArea_Standart_ReturnsArea()
        {
            Circle circle = new Circle(10);

            var result = circle.GetArea();

            Assert.AreEqual(result, Math.PI * 100);
        }
        [TestMethod]
        public void TriangleGetArea_Standart_ReturnsArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.GetArea();

            Assert.AreEqual(result, 6);
        }
        [TestMethod]
        public void CreateCircle_NegativeOrNullRadius_OutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
        }
        [TestMethod]
        public void CreateTriangle_NegativeOrNullSides_OutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-10, 10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(10, -10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(10, 10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(10, 0, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(10, 10, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
        }
        [TestMethod]
        public void IsRightTriangle_Right_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRightTriangle();

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsRightTriangle_Equilateral_ReturnsFalse()
        {
            Triangle triangle = new Triangle(5, 5, 5);

            var result = triangle.IsRightTriangle();

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsRightTriangle_NotRight_ReturnsFalse()
        {
            Triangle triangle = new Triangle(4, 5, 10);

            var result = triangle.IsRightTriangle();

            Assert.IsFalse(result);
        }
    }
}
