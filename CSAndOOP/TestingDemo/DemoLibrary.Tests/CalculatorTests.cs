using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3,4,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(26.25, 5.25, 21)]
        [InlineData(-10, -20, 10)]
        [InlineData(double.MinValue, -5, double.MinValue)]
        public void Subtract_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(26.25, 5.25, 137.8125)]
        [InlineData(-10, -20, 200)]
        [InlineData(double.MaxValue, 2, double.MaxValue)]
        public void Multiply_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Multiply(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
