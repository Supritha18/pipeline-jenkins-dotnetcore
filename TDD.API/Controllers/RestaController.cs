using Microsoft.AspNetCore.Mvc;
using StructureMap;
using TDD.API.Interfaces;

namespace TDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaController : ControllerBase
    {

        private readonly IOperacionesService _service;

        public RestaController(IContainer service)
        {
            _service = service.GetInstance<IOperacionesService>("A");
        }

        // GET: api/Suma/5
        public ActionResult Get(double input1, double input2)
        {
            return Ok(_service.Get(input1, input2));
        }

    }
}
