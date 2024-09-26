using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace puc_6s.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [JsonIgnore]
        public string Password { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
        public ICollection<ConsultaUsuarios> Consultas{ get; set; }
    }

    public enum Perfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Paciente")]
        Paciente,
        [Display(Name = "Medico")]
        Medico,
    }
}
