using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomlyAPI.Domains;
using RoomlyAPI.Interfaces;
using RoomlyAPI.Repositories;

namespace RoomlyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SalaController : ControllerBase
    {
        private ISalaRepository _salaRepository { get; set; }

        public SalaController()
        {
            _salaRepository = new SalaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_salaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_salaRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Sala sala)
        {
            try
            {
                _salaRepository.Cadastrar(sala);

                return StatusCode(201, sala);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
