
using System.ComponentModel.DataAnnotations;

namespace EFAcademy.Data.Entities
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoId { get; set; }
        public decimal Nota { get; set; }
        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }
    }
}
