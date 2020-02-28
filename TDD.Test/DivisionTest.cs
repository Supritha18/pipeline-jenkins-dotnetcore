using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(10, 2, 5)]
        [TestCase(5, 0, double.NaN)]
        public void DivisionUTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Division division = new Division();
            //  Arrange **

            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = division.Operar(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }
    }
}
