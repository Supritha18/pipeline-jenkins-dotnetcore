using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using StructureMap;
using TDD.API.Controllers;
using TDD.API.Interfaces;
using TDD.API.Services;

namespace TDD.API.Test
{
    public class MultiplicacionTest
    {
        MultiplicacionController _controller;
        Container _container;


        [OneTimeSetUp]
        public void MultiplicacionTestSetUp()
        {
            _container = new Container();
            _container.Configure(config =>
            {
                config.For<IOperacionesService>().Add(new MultiplicacionService()).Named("C");
            });
            _controller = new MultiplicacionController(_container);
        }

        [TestCase(0, 0)]
        public void MultiplicacionGet(double input1, double input2)
        {
            // Act
            var okResult = _controller.Get(input1, input2);
            // Assert
            Assert.AreEqual(typeof(OkObjectResult), okResult.GetType());
        }



        [TestCase(300, 5, 1500)]
        [TestCase(45, 5, 225)]
        [TestCase(-10, 20, -200)]
        public void MultiplicacionGetValue(double input1, double input2, double expectedResult)
        {
            // Act
            var okResult = _controller.Get(input1, input2) as OkObjectResult;
            // Assert
            Assert.AreEqual(expectedResult, okResult.Value);

        }

    }
}
