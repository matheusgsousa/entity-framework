using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data.Entities
{
    public class Pedido
    {
        [Key]
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }
        public List<ItemPedido> Pedidos { get; set; }
        public string CEP { get; set; }
        public DateTime Data { get; set; }
        public int PagamentoId { get; set; }

        
    }
}
