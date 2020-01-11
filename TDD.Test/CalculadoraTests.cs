using NUnit.Framework;
using TDD.ClassLibrary;


namespace TDD.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {

        [TestCase(1, 0, 1)]
        [TestCase(10, 5, 15)]
        [TestCase(20, 10, 30)]
        [TestCase(70, 5, 75)]
        public void SumaTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Calculadora calculadora = new Calculadora();

            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = calculadora.Suma(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **
        }

        [Test()]
        public void RestaTest()
        {
            // ** Arrange
            // Create instance calculadora
            Calculadora calculadora = new Calculadora();

            // Definir una entrada y una salida
            double expectedResult = 1;
            double input1 = 2;
            double input2 = 1;
            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = calculadora.Resta(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }

        [TestCase(5, 5, 25)]
        [TestCase(5, 0, 0)]
        public void MultiplicacionTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Calculadora calculadora = new Calculadora();



            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = calculadora.Multiplicacion(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }

        [TestCase(10, 2, 5)]
        [TestCase(5, 0, double.NaN)]
        public void DivisionTest(double input1, double input2, double expectedResult)
        {
            // ** Arrange
            // Create instance calculadora
            Calculadora calculadora = new Calculadora();
            //  Arrange **

            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = calculadora.Division(input1, input2);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }


        [Test]
        public void RadicacionTest()
        {
            // ** Arrange
            // Create instance calculadora
            Calculadora calculadora = new Calculadora();

            // Definir una entrada y una salida
            double expectedResult = 5;
            double input1 = 25;
            //  Arrange **


            // ** Act
            // Ejecutar el metodo bajo prueba:
            double actualResult = calculadora.Radicacion(input1);
            //  Act **

            // ** Assert
            // Verificar el resultado:
            Assert.AreEqual(expectedResult, actualResult);
            // Assert **

        }
        [Test]
        public void PotenciacionTest()
        {
            // **Arrange 
            Calculadora calculadora = new Calculadora();
            double expectedResult = 100;
            double input1 = 10;
            double input2 = 2;


            // ** Act
            double actResult = calculadora.Potenciacion(input1, input2);


            // ** Assert
            Assert.AreEqual(expectedResult, actResult);
        }
    }
}