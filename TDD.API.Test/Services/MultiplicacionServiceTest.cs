using NUnit.Framework;
using TDD.API.Services;

namespace TDD.API.Test.Services
{
    [TestFixture]
    public class MultiplicacionServiceTest
    {

        [TestCase(0, 0, 0)]
        [TestCase(-10, 2, -20)]
        [TestCase(1000, 2, 2000)]
        public void MultiplicacionServiceGet(double input1, double input2, double expected)
        {
            // Arrange
            MultiplicacionService multiplicacionService = new MultiplicacionService();

            // Act
            double result = multiplicacionService.Get(input1, input2);

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}
