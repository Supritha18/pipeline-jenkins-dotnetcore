using TDD.API.Interfaces;
using TDD.ClassLibrary;

namespace TDD.API.Services
{
    public class RestaService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            Resta resta = new Resta();
            return resta.Operar(input1, input2);
        }
    }
}
