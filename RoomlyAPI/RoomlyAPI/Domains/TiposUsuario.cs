using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomlyAPI.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Tipo do usuário obrigatório!")]
        public string? TituloTipoUsuario { get; set; }
    }
}
