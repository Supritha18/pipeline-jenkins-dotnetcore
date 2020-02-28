using TDD.ClassLibrary.interfaces;

namespace TDD.ClassLibrary
{
    public class OperacionEspecial : IOperaciones
    {
        public double Operar(double input1, double input2)
        {
            if (input2 == 0)
            {
                return double.NaN;
            }
            return (input1 + input2) / input2;
        }
    }
}
