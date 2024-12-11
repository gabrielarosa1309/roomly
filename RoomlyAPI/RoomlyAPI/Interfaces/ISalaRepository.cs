using RoomlyAPI.Domains;

namespace RoomlyAPI.Interfaces
{
    public interface ISalaRepository
    {
        void Cadastrar(Sala sala);

        Sala BuscarPorId(Guid id);

        List<Sala> Listar();
    }
}
