using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.API.Interfaces;

namespace TDD.API.Services
{
    public class MultiplicacionService : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            return input1 * input2;
        }
    }
}
