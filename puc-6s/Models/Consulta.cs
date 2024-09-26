using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace puc_6s.Models
{
    [Table("Consultas")]
    public class Consulta : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdPaciente { get; set; }
        [Required]
        public int IdMedico { get; set; }
        [Required]
        public DateOnly Data { get; set; }
        [Required]
        public TimeOnly Hora { get; set; }
        [Required]
        public Status Status { get; set; }
        public ICollection<Notificacao> Notificacoes { get; set; }

        public ICollection<ConsultaUsuarios> Usuarios { get; set; }

        public enum Status
        {
            [Display(Name = "Marcada")]
            Marcada,
            [Display(Name = "Cancelada")]
            Cancelada,
            [Display(Name = "Realizada")]
            Realizada,
            [Display(Name = "Ausente")]
            Ausente
        }
    }
}
