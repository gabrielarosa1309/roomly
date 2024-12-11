using RoomlyAPI.Domains;

namespace RoomlyAPI.Interfaces
{
    public interface ITiposUsuarioRepository
    {
        void Cadastrar(TiposUsuario tipoUsuario);

        TiposUsuario BuscarPorId(Guid id);

        List<TiposUsuario> Listar();
    }
}
