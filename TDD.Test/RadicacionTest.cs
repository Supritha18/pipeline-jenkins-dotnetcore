using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class RadicacionTest
    {
        [Test]
        public void RadicacionUTest()
        {
            // ** Arrange
            // Create instance calculadora
            Radicacion radicacion = new Radicacion();

            // Definir una entrada y una salida
            double expectedResult = 5;
            double input1 = 25;
            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = radicacion.Operar(input1, -1);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }
    }
}
