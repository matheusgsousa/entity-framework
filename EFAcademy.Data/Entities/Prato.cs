using EFAcademy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EFAcademy.Data.Entities
{
    public class Prato
    {
        [Key]
        public int PratoId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Nome { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public int EmpresaId { get; set; }
        public TipoPrato Tipo { get; set; }

    }
}
