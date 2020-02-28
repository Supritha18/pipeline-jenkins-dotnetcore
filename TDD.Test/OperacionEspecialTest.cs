using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class OperacionEspecialTest
    {
        [TestCase(1, 0, double.NaN)]
        [TestCase(10, 5, 3)]
        [TestCase(20, 10, 3)]
        public void PotenciacionUTest(double input1, double input2, double expectedResult)
        {
            // **Arrange 
            OperacionEspecial operacionEspecial = new OperacionEspecial();

            // ** Act
            double actResult = operacionEspecial.Operar(input1, input2);


            // ** Assert
            Assert.AreEqual(expectedResult, actResult);
        }
    }
}
