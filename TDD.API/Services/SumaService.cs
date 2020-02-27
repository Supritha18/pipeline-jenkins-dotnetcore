using TDD.API.Interfaces;
using TDD.ClassLibrary;

namespace TDD.API.Services
{
    public class SumaService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            Suma suma = new Suma();
            return suma.Operar(input1, input2);
        }
    }
}
