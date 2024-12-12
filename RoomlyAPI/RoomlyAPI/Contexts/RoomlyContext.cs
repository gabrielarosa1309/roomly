using Microsoft.EntityFrameworkCore;
using RoomlyAPI.Domains;

namespace RoomlyAPI.Contexts
{
    /// <summary>
    /// Classe de contexto que faz referências as tabelas e define string de conexão
    /// </summary>
    public class RoomlyContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Equipamentos> Equipamentos { get; set; }

        public DbSet<Sala> Sala { get; set; }

        public DbSet<Reserva> Reserva { get; set; }


        /// <summary>
        /// Define as opções de construção do banco
        /// </summary>
        /// <param name="optionsBuilder">Objeto com as configurações definidas</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=INV11134\\SQLEXPRESS; initial catalog=Roomly; Trusted_Connection=True; Integrated Security=true; TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
