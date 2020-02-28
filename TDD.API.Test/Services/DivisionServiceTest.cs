using NUnit.Framework;
using TDD.API.Services;

namespace TDD.API.Test.Services
{
    [TestFixture]
    public class DivisionServiceTest
    {
        [TestCase(5, 5, 1)]
        [TestCase(-5, 2, -2.5)]
        [TestCase(5, 0, double.NaN)]
        public void DivisionServiceGet(double input1, double input2, double expectedResult)
        {
            // Arrange
            DivisionService divionService = new DivisionService();


            // Act
            double result = divionService.Get(input1, input2);

            // Assert
            Assert.AreEqual(result, expectedResult);

        }
    }
}
