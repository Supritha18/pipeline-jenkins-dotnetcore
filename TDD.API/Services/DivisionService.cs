
using TDD.API.Interfaces;
using TDD.ClassLibrary;

namespace TDD.API.Services
{
    public class DivisionService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            if (input2 == 0)
            {
                return double.NaN;
            }
            Calculadora calculadora = new Calculadora();
            return calculadora.Division(input1, input2);
        }

    }
}
