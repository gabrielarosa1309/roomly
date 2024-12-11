using RoomlyAPI.Domains;

namespace RoomlyAPI.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(string email, string senha);

        List<Usuario> Listar();
    }
}
