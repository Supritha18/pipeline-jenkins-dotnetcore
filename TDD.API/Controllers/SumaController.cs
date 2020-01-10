using Microsoft.AspNetCore.Mvc;
using StructureMap;
using TDD.API.Interfaces;

namespace TDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        private readonly IOperacionesService _service;

        public SumaController(IContainer service)
        {
            _service = service.GetInstance<IOperacionesService>("B");
        }

        // GET: api/Suma/5
        public ActionResult Get(double input1, double input2)
        {
            return Ok(_service.Get(input1, input2));
        }
    }
}
