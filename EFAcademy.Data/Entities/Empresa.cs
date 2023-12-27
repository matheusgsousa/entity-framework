using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data.Entities
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(14)]
        public string? CNPJ { get; set; }
        [Required]
        [StringLength(11)]
        public string? Telefone { get; set; }
        [ForeignKey("PratoId")]
        public List<Prato>? Cardapio { get; set; }
        public decimal AvaliacaoGeral { get; set; }
    }
}
