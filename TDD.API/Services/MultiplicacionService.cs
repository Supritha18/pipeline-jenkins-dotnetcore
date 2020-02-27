using TDD.API.Interfaces;
using TDD.ClassLibrary;

namespace TDD.API.Services
{
    public class MultiplicacionService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            Multiplicacion multiplicacion = new Multiplicacion();
            return multiplicacion.Operar(input1, input2);
        }
    }
}
