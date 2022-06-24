using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 7, 5, 15)]
        [InlineData(2, 2, 2, 6)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator adder = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = adder.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,3,7)]
        [InlineData(5,6,-1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator subtracter = new Calculator();

            //Act
            var actual = subtracter.Minus(minuend,subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(12,12,144)]
        [InlineData(-6,5,-30)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator multipler = new Calculator();
            //Act
            var actual = multipler.Multiply(num1,num2);
            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        [InlineData(2,0,0)] //assume anything divided by zero equals zero
        [InlineData(-10,5,-2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator divider = new Calculator();
            //Act
            var actual = divider.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
