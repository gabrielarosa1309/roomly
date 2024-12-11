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
    public class ReservaController : ControllerBase
    {
        private IReservaRepository _reservaRepository { get; set; }

        public ReservaController()
        {
            _reservaRepository = new ReservaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_reservaRepository.Listar());
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
                return Ok(_reservaRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Reserva reserva)
        {
            try
            {
                _reservaRepository.Cadastrar(reserva);

                return StatusCode(201, reserva);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
