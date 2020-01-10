using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.API.Interfaces;

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
            return input1 / input2;
        }

    }
}
