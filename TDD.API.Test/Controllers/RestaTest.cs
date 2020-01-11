using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using TDD.API.Controllers;
using TDD.API.Interfaces;
using TDD.API.Services;

namespace TDD.API.Test
{
    public class RestaTest
    {
        RestaController _controller;
        IEnumerable<IOperacionesService> _service;


        [OneTimeSetUp]
        public void RestaTestSetUp()
        {
            _service = new List<RestaService>() { new RestaService() };
            _controller = new RestaController(_service);
        }

        [TestCase(0, 0)]
        public void RestaGet(double input1, double input2)
        {
            // Act
            var okResult = _controller.Get(input1, input2);
            // Assert
            Assert.AreEqual(typeof(OkObjectResult), okResult.GetType());
        }



        [TestCase(300, 5, 295)]
        [TestCase(45, 5, 40)]
        [TestCase(-10, 20, -30)]
        public void RestaGetValue(double input1, double input2, double expectedResult)
        {
            // Act
            var okResult = _controller.Get(input1, input2) as OkObjectResult;
            // Assert
            Assert.AreEqual(expectedResult, okResult.Value);

        }
    }
}
