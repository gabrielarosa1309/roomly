using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomlyAPI.Domains
{
    [Table("Equipamentos")]
    public class Equipamentos
    {
        [Key]
        public Guid IdEquipamento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Equipamento obrigatório!")]
        public string? TituloEquipamento { get; set; }
    }
}
