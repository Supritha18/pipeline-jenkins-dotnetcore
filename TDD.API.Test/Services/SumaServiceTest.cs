using NUnit.Framework;
using TDD.API.Services;

namespace TDD.API.Test.Services
{
    [TestFixture]
    public class SumaServiceTest
    {

        [TestCase(1, 1, 2)]
        [TestCase(1000, -1000, 0)]
        [TestCase(-111, 1, -110)]
        public void SumaServiceGet(double input1, double input2, double expectedResult)
        {
            // Arrange
            SumaService sumaService = new SumaService();

            // Act
            double result = sumaService.Get(input1, input2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
