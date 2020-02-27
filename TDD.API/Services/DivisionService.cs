
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
            Division division = new Division();
            return division.Operar(input1, input2);
        }

    }
}
