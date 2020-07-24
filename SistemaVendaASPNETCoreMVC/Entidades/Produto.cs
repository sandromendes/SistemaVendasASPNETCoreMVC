using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendaASPNETCoreMVC.Entidades
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("produto_id")]
        public int? ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int quantidade { get; set; }

        [ForeignKey("Categoria")]
        [Column("categoria_id")]
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }

        public List<VendaProduto> Vendas { get; set; }
    }
}
