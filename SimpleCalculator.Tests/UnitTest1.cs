using System;
using Xunit;
using SimpleCalculator;
namespace SimpleCalculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AddingNumbersTest()
        {
            //Arrange
            double expected = 5.5;
            //Act
            
            double actual = Program.Addition(3.2,2.3);
            //Assert
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void SubstractionNumbersTest()
        {
            //Arrange
            double expected = 3.2;
            //Act

            double actual = Program.Subtraction(5.2,2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiplicationNumbersTest()
        {
            //Arrange
            double expected = 10.4;
            //Act

            double actual = Program.Multiplication(5.2, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddtionArrayTest()
        {
            //Arrange
            int[] arrayOne = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrayTwo = new int[5] { 5, 4, 3, 2, 1 };
            //int[] resultArray = new int[5];
            int[] expectedresultArray = { 6,6,6,6,6};


            //Act

            int[] actual = Program.Addition(arrayOne, arrayTwo);
            //Assert
            Assert.Equal(expectedresultArray, actual);
            
        }
        [Fact]
        public void SubstractionArrayTest()
        {
            //Arrange
            int[] arrayOne = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrayTwo = new int[5] { 5, 4, 3, 2, 1 };
            //int[] resultArray = new int[5];
            int[] expectedresultArray = { -4, -2, 0, 2, 4};


            //Act

            int[] actual = Program.Substraction(arrayOne, arrayTwo);
            //Assert
            Assert.Equal(expectedresultArray, actual);
        }

        [Theory]
        [InlineData(8,2, 4)]
        [InlineData(8.0, 2.5, 3.2)]
        public void DivisionTest(double dividend,double divider,double expected)
        {
            //Arrange
            

            //Act

            double actual = Program.Division(dividend,divider );
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivisionbyZero()
        {
            //Arrange

            double expected = 0;
            //Act

            double actual = Program.Division(10, 0);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
