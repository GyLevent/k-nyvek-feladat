using AdatbazisAPI.Models.Dtos;
using AdatbazisAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdatbazisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KonyvController : ControllerBase
    {
        private readonly IKonyvekInterface konyvInterface;

        public KonyvController(IKonyvekInterface konyvInterface)
        {
            this.konyvInterface = konyvInterface;
        }
        [HttpPost]
        public async Task<ActionResult<Konyv>> Post(CreateKonyv createkonyv)
        {
            return StatusCode(201, await konyvInterface.Post(createkonyv));
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Konyv>> Get(Guid Id)
        {
            return StatusCode(200, await konyvInterface.GetById(Id));
        }
        [HttpGet]
        public async Task<ActionResult<Konyv>> Get()
        {
            return StatusCode(200, await konyvInterface.Get());
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Konyv>> DeleteById(Guid Id)
        {
            return StatusCode(200, await konyvInterface.DeleteById(Id));
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<Konyv>> Put(Guid Id, UpdateKonyv updatekonyv)
        {
            return StatusCode(200, await konyvInterface.Put(Id, updatekonyv));
        }
    }
}
