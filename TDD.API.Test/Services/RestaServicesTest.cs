using NUnit.Framework;
using TDD.API.Services;

namespace TDD.API.Test.Services
{
    [TestFixture]
    public class RestaServicesTest
    {
        [TestCase(1, 1, 0)]
        [TestCase(1000, -1000, 2000)]
        [TestCase(-111, 1, -112)]
        public void RestaServiceGet(double input1, double input2, double expectedResult)
        {
            // Arrange
            RestaService resService = new RestaService();

            // Act
            double result = resService.Get(input1, input2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
