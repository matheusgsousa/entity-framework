using System.ComponentModel.DataAnnotations;

namespace EFAcademy.Data.Entities
{
    public class ItemPedido
    {
        [Key]
        public int ItemPedidoId { get; set; }
        public int? BebidaId { get; set; }
        public int? PratoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public int PedidoId { get; set; }
    }
}
