using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(6, 4, 10, 20)]
        [InlineData(2, 3, 5, 10)]  //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var Addcalculator = new Calculator();  


            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = Addcalculator.Add(num1, num2, num3);
            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 50, 0)]
        [InlineData(10, 5, 5)]
        [InlineData(5, 3, 2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Subtractcalculator = new Calculator();
            //Act
            var actual = Subtractcalculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(2, 2, 4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Multiplycalculator = new Calculator();

            //Act
            var actual = Multiplycalculator.Multiply(num1, num2); 
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(25, 5, 5)]
        [InlineData(10, 2, 5)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var DivideCalculator = new Calculator();
            //Act
            var actual = DivideCalculator.Divide(num1, num2); 
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
