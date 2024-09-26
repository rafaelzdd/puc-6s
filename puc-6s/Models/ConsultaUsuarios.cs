using System.ComponentModel.DataAnnotations.Schema;

namespace puc_6s.Models
{
    [Table("ConsultaUsuarios")]
    public class ConsultaUsuarios
    {
        public int ConsultaId { get; set; }
        public Consulta Consulta { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
