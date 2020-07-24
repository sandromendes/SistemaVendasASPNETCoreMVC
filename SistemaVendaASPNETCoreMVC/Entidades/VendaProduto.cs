using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendaASPNETCoreMVC.Entidades
{
    [Table("VendaProduto")]
    public class VendaProduto
    {
        [Column("venda_id")]
        public int VendaId { get; set; }
        [Column("produto_id")]
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        [Column("valor_unitario")]
        public decimal ValorUnitario { get; set; }
        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        public Produto Produto { get; set; }
        public Venda Venda { get; set; }
    }
}
