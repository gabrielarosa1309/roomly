using RoomlyAPI.Domains;

namespace RoomlyAPI.Interfaces
{
    public interface IReservaRepository
    {
        void Cadastrar(Reserva reserva);

        Reserva BuscarPorId(Guid id);

        List<Reserva> Listar();
    }
}
