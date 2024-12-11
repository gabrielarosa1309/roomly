using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomlyAPI.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public string? Nome { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Email do usuário é obrigatório!")]
        public string? Email { get; set; }


        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha do usuário é obrigatória!")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 60 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$",
        ErrorMessage = "A senha deve conter pelo menos uma letra maiúscula, uma letra minúscula e um número.")]
        public string? Senha { get; set; }


        //referência para a entidade TiposUsuario

        [Required(ErrorMessage = "O tipo do usuário é obrigatório!")]
        public Guid IdTipoUsuario { get; set; }


        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TipoUsuario { get; set; }
    }
}
