using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.API.Controllers;
using TDD.API.Interfaces;
using TDD.API.Services;

namespace TDD.API.Test
{
    public class RestaTest
    {
        RestaController _controller;
        Container _container;


        [OneTimeSetUp]
        public void RestaTestSetUp()
        {
            _container = new Container();
            _container.Configure(config =>
            {
                config.For<IOperacionesService>().Add(new RestaService()).Named("A");
            });
            _controller = new RestaController(_container);
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
