using EFAcademy.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAcademy.Data.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Prato> Prato { get; set; }
        public DbSet<Entregador> Entregador { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Bebida> Bebida { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set;}
         
    }               
}                   
