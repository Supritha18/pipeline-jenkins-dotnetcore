using System;
using System.Collections.Generic;
using System.Text;
using TDD.API.Interfaces;

namespace TDD.API.Test.Fakes
{
    public class SumaServiceFake : IOperacionesService
    {
        public double Get(double input1, double input2)
        {
            return input1 + input2;
        }
    }
}
