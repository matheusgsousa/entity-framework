using EFAcademy.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace EFAcademy.Data.Entities
{
    public class Bebida
    {
        [Key]
        public int BebidaId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Nome { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public int EmpresaId { get; set; }
        public TipoBebida Tipo { get; set; }

    }
}
