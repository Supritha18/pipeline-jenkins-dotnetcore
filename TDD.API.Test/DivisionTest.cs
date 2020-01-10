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
    public class DivisionTest
    {
        DivisionController _controller;
        Container _container;


        [OneTimeSetUp]
        public void DivisionTestSetUp()
        {
            _container = new Container();
            _container.Configure(config =>
            {
                config.For<IOperacionesService>().Add(new DivisionService()).Named("D");
            });
            _controller = new DivisionController(_container);
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
