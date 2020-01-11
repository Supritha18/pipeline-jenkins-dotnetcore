using TDD.API.Interfaces;
using TDD.ClassLibrary;

namespace TDD.API.Services
{
    public class RestaService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            Calculadora calculadora = new Calculadora();
            return calculadora.Resta(input1, input2);
        }
    }
}
