using EFAcademy.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data.Entities
{
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }
        public TipoPagamento Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
