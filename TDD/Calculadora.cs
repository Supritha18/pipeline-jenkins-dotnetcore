using System;

namespace TDD
{
    public class Calculadora
    {
        public double Suma(double input1, double input2)
        {

            return input1 + input2;
        }

        public double Resta(double input1, double input2)
        {
            return input1 - input2;
        }

        public double Multiplicacion(double input1, double input2)
        {
            return input1 * input2;
        }

        public double Division(double input1, double input2)
        {
            if (input2 == 0)
            {
                return double.NaN;
            }
            return input1 / input2;
        }

        public double Radicacion(double input1)
        {
            return Math.Sqrt(input1);
        }

        public double Potenciacion(double input1, double input2)
        {
            return Math.Pow(input1, input2);
        }
    }
}