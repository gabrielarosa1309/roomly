using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomlyAPI.Domains
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public Guid IdReserva { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data da reserva é obrigatória!")]
        public DateTime DataReserva { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "O horário da reserva é obrigatório!")]
        public TimeSpan HorarioReserva { get; set; }


        //referência para a entidade Usuario

        [Required(ErrorMessage = "O usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }


        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }

        //referência para a entidade Sala

        [Required(ErrorMessage = "A sala é obrigatória!")]
        public Guid IdSala { get; set; }


        [ForeignKey("IdSala")]
        public Sala? Sala { get; set; }
    }
}
