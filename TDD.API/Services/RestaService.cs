using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.API.Interfaces;

namespace TDD.API.Services
{
    public class RestaService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            TDD.Calculadora calculadora = new Calculadora();
            return calculadora.Resta(input1, input2);
        }
    }
}
