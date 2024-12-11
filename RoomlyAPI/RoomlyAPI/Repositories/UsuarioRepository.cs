using RoomlyAPI.Interfaces;
using RoomlyAPI.Domains;
using RoomlyAPI.Contexts;
using RoomlyAPI.Utils;

namespace RoomlyAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RoomlyContext _context;

        public UsuarioRepository()
        {
            _context = new RoomlyContext();
        }

        public Usuario BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,

                        TipoUsuario = new TiposUsuario
                        {
                            IdTipoUsuario = u.IdTipoUsuario,
                            TituloTipoUsuario = u.TipoUsuario!.TituloTipoUsuario
                        }
                    }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                Usuario usuarioBuscado = _context.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,

                        TipoUsuario = new TiposUsuario
                        {
                            TituloTipoUsuario = u.TipoUsuario!.TituloTipoUsuario
                        }

                    }).FirstOrDefault(u => u.IdUsuario == id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
