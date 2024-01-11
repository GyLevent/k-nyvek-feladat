using AdatbazisAPI.Models.Dtos;
using AdatbazisAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdatbazisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzerzoController : ControllerBase
    {
        private readonly ISzerzoInterface szerzoInterface;

        public SzerzoController(ISzerzoInterface szerzoInterface)
        {
            this.szerzoInterface = szerzoInterface;
        }
        [HttpPost]
        public async Task<ActionResult<Szerzo>> Post(CreateSzerzo createszerzo)
        {
            return StatusCode(201, await szerzoInterface.Post(createszerzo));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Szerzo>> Get(Guid Id)
        {
            return StatusCode(200, await szerzoInterface.GetById(Id));
        }
        [HttpGet]
        public async Task<ActionResult<Szerzo>> Get()
        {
            return StatusCode(200, await szerzoInterface.Get());
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Szerzo>> DeleteById(Guid Id)
        {
            return StatusCode(200, await szerzoInterface.DeleteById(Id));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<Szerzo>> Put(Guid Id, UpdateSzerzo updateSzerzo)
        {
            return StatusCode(200, await szerzoInterface.Put(Id, updateSzerzo));
        }
    }
}
