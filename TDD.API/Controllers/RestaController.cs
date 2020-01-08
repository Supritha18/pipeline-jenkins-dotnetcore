using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TDD.API.Interfaces;
using TDD.API.Services;

namespace TDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaController : ControllerBase
    {

        private readonly IOperacionesService _service;

        public RestaController(IOperacionesService service)
        {
            _service = service;
        }

        // GET: api/Suma/5
        public ActionResult Get(double input1, double input2)
        {
            return Ok(_service.Get(input1, input2));
        }

    }
}
