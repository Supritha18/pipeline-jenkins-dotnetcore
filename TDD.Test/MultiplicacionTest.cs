using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class MultiplicacionTest
    {
        [TestCase(5, 5, 25)]
        [TestCase(5, 0, 0)]
        public void MultiplicacionUTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Multiplicacion multiplicacion = new Multiplicacion();



            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = multiplicacion.Operar(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }
    }
}
