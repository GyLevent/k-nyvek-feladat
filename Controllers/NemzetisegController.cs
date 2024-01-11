using AdatbazisAPI.Models.Dtos;
using AdatbazisAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdatbazisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NemzetisegController : ControllerBase
    {
        private readonly INemzetisegekInterface nemzetiseginterface;

        public NemzetisegController(INemzetisegekInterface nemzetisegekInterface)
        {
            this.nemzetiseginterface = nemzetiseginterface;
        }
        [HttpPost]
        public async Task<ActionResult<Nemzetiseg>> Post(CreateNemzetiseg createNemzetiseg)
        {
            return StatusCode(201, await nemzetiseginterface.Post(createNemzetiseg));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Nemzetiseg>> Get(Guid Id)
        {
            return StatusCode(200, await nemzetiseginterface.GetById(Id));
        }
        [HttpGet]
        public async Task<ActionResult<Nemzetiseg>> Get()
        {
            return StatusCode(200, await nemzetiseginterface.Get());
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Nemzetiseg>> DeleteById(Guid Id)
        {
            return StatusCode(200, await nemzetiseginterface.DeleteById(Id));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<Nemzetiseg>> Put(Guid Id, UpdateNemzetiseg updateNemzetiseg)
        {
            return StatusCode(200, await nemzetiseginterface.Put(Id, updateNemzetiseg));
        }
    }
}
