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
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuarioRepository _tiposUsuarioRepository { get; set; }

        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposUsuarioRepository.Listar());
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
                return Ok(_tiposUsuarioRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tiposUsuario);

                return StatusCode(201, tiposUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
