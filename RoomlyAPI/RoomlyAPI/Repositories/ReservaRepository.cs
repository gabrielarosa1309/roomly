using RoomlyAPI.Interfaces;
using RoomlyAPI.Domains;
using RoomlyAPI.Contexts;

namespace RoomlyAPI.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly RoomlyContext _context;

        public ReservaRepository()
        {
            _context = new RoomlyContext();
        }

        public Reserva BuscarPorId(Guid id)
        {
            try
            {
                return _context.Reserva.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Reserva reserva)
        {
            try
            {
                _context.Reserva.Add(reserva);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Reserva> Listar()
        {
            try
            {
                return _context.Reserva.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
