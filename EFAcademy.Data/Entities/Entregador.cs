using EFAcademy.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data.Entities
{
    public class Entregador
    {
        [Key]
        public int EntregadorId { get; set; }
        public string Nome { get; set; }
        [Required]
        public string CNH { get; set; }
        public TipoVeiculo Veiculo { get; set; }
    }
}
