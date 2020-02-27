using System;
using TDD.ClassLibrary.interfaces;

namespace TDD.ClassLibrary
{
    public class Potenciacion : IOperaciones
    {
        public double Operar(double input1, double input2)
        {
            return Math.Pow(input1, input2);
        }
    }
}
