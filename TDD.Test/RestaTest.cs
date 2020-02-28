using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class RestaTest
    {
        [Test()]
        public void RestaUTest()
        {
            // ** Arrange
            // Create instance calculadora
            Resta resta = new Resta();

            // Definir una entrada y una salida
            double expectedResult = 1;
            double input1 = 2;
            double input2 = 1;
            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = resta.Operar(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }
    }
}
