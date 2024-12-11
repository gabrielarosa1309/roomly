using RoomlyAPI.Interfaces;
using RoomlyAPI.Domains;
using RoomlyAPI.Contexts;

namespace RoomlyAPI.Repositories
{
    public class EquipamentosRepository : IEquipamentoRepository
    {
        private readonly RoomlyContext _context;

        public EquipamentosRepository()
        {
            _context = new RoomlyContext();
        }

            
        public void Cadastrar(Equipamentos equipamento)
        {
            try
            {
                _context.Equipamentos.Add(equipamento);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Equipamentos BuscarPorId(Guid id)
        {
            try
            {
                return _context.Equipamentos.Find(id)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Equipamentos> Listar()
        {
            try
            {
                return _context.Equipamentos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
