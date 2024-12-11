using RoomlyAPI.Interfaces;
using RoomlyAPI.Domains;
using RoomlyAPI.Contexts;

namespace RoomlyAPI.Repositories
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        private readonly RoomlyContext _context;

        public TiposUsuarioRepository()
        {
            _context = new RoomlyContext();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            try
            {
                return _context.TiposUsuario.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            try
            {
                _context.TiposUsuario.Add(tipoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TiposUsuario> Listar()
        {
            try
            {
                return _context.TiposUsuario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
