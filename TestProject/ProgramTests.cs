using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            //Arrange
            Program prog = new Program();
            int expectedResult = 5;
            int input1 = 2, input2 = 3;

            //Act
            int result = prog.Addition(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod()]
        public void SubtractionTest()
        {
            //Arrange
            Program prog = new Program();
            int expectedResult = 1;
            int input1 = 5, input2 = 4;

            //Act
            int result = prog.Subtraction(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}