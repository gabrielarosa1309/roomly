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
    public class EquipamentoController : ControllerBase
    {
        private IEquipamentoRepository _equipamentoRepository { get; set; }

        public EquipamentoController()
        {
            _equipamentoRepository = new EquipamentosRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_equipamentoRepository.Listar());
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
                return Ok(_equipamentoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Equipamentos equipamento)
        {
            try
            {
                _equipamentoRepository.Cadastrar(equipamento);

                return StatusCode(201, equipamento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
