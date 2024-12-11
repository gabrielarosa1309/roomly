using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomlyAPI.Domains
{
    [Table("Sala")]
    public class Sala
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O título da sala é obrigatório!")]
        public string? TituloSala { get; set; }

        [Column(TypeName = "INTEGER")]
        [Required(ErrorMessage = "A capacidade da sala é obrigatória!")]
        public string? Capacidade { get; set; }


        //referência para a entidade TiposUsuario

        [Required(ErrorMessage = "Os equipamentos são obrigatórios!")]
        public Guid IdEquipamento { get; set; }


        [ForeignKey("IdEquipamento")]
        public Equipamentos? Equipamento { get; set; }
    }
}
