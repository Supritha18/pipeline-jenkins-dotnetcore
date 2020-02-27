using System;
using TDD.ClassLibrary.interfaces;

namespace TDD.ClassLibrary
{
    public class Radicacion : IOperaciones
    {
        public double Operar(double input1, double input2)
        {
            return Math.Sqrt(input1);
        }

    }
}
