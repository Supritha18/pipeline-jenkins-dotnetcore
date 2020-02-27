using TDD.ClassLibrary.interfaces;

namespace TDD.ClassLibrary
{
    public class Division : IOperaciones
    {

        public double Operar(double input1, double input2)
        {
            if (input2 == 0)
            {
                return double.NaN;
            }
            return input1 / input2;
        }
    }
}
