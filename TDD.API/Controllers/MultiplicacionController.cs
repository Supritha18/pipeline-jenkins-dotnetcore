using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TDD.API.Interfaces;

namespace TDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplicacionController : ControllerBase
    {
        private readonly IOperacionesService _service;

        public MultiplicacionController(IEnumerable<IOperacionesService> service)
        {
            _service = service.FirstOrDefault(h => h.GetType().Name == "MultiplicacionService");
        }

        // GET: api/Suma/5
        public ActionResult Get(double input1, double input2)
        {
            return Ok(_service.Get(input1, input2));
        }
    }
}
