using RoomlyAPI.Domains;

namespace RoomlyAPI.Interfaces
{
    public interface IEquipamentoRepository
    {
        void Cadastrar(Equipamentos equipamento);

        Equipamentos BuscarPorId(Guid id);

        List<Equipamentos> Listar();
    }
}
