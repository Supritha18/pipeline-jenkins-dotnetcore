using TDD.ClassLibrary.interfaces;

namespace TDD.ClassLibrary
{
    public class Suma : IOperaciones
    {
        public double Operar(double input1, double input2)
        {
            return input1 + input2;
        }
    }
}
