using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using TDD.API.Controllers;
using TDD.API.Interfaces;
using TDD.API.Services;

namespace TDD.API.Test
{
    public class DivisionTest
    {
        DivisionController _controller;
        IEnumerable<IOperacionesService> _service;


        [OneTimeSetUp]
        public void DivisionTestSetUp()
        {
            _service = new List<DivisionService>() { new DivisionService() };
            _controller = new DivisionController(_service);
        }

        [TestCase(1, 1)]
        public void DivisionGet(double input1, double input2)
        {
            // Act
            var okResult = _controller.Get(input1, input2);

            // Assert
            Assert.AreEqual(typeof(OkObjectResult), okResult.GetType());
        }



        [TestCase(300, 5, 60)]
        [TestCase(45, 5, 9)]
        [TestCase(-10, 5, -2)]
        [TestCase(5, 0, double.NaN)]
        public void DivisionGetValue(double input1, double input2, double expectedResult)
        {

            // Act
            var okResult = _controller.Get(input1, input2) as OkObjectResult;

            // Assert
            Assert.AreEqual(expectedResult, okResult.Value);

        }
    }
}
