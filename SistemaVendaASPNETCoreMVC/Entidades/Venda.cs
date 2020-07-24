using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendaASPNETCoreMVC.Entidades
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        [Column("venda_id")]
        public int? VendaId { get; set; }
        public DateTime Data { get; set; }
        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [ForeignKey("Categoria")]
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; }
    }
}
