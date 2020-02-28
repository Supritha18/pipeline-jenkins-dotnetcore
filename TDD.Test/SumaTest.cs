using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class SumaTest
    {
        [TestCase(1, 0, 1)]
        [TestCase(10, 5, 15)]
        [TestCase(20, 10, 30)]
        [TestCase(70, 5, 75)]
        public void SumaUTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Suma suma = new Suma();

            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = suma.Operar(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **
        }
    }
}
