using NUnit.Framework;
using TDD.ClassLibrary;

namespace TDD.Test
{
    [TestFixture]
    public class PotenciacionTest
    {

        [Test]
        public void PotenciacionUTest()
        {
            // **Arrange 
            Potenciacion potenciacion = new Potenciacion();
            double expectedResult = 100;
            double input1 = 10;
            double input2 = 2;


            // ** Act
            double actResult = potenciacion.Operar(input1, input2);


            // ** Assert
            Assert.AreEqual(expectedResult, actResult);
        }
    }
}
