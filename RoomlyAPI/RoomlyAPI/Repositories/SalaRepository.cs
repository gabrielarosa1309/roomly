using RoomlyAPI.Interfaces;
using RoomlyAPI.Domains;
using RoomlyAPI.Contexts;

namespace RoomlyAPI.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        private readonly RoomlyContext _context;

        public SalaRepository()
        {
            _context = new RoomlyContext();
        }

        public Sala BuscarPorId(Guid id)
        {
            try
            {
                return _context.Sala.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Sala sala)
        {
            try
            {
                _context.Sala.Add(sala);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Sala> Listar()
        {
            try
            {
                return _context.Sala.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
