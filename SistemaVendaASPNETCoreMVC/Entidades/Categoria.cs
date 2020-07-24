using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendaASPNETCoreMVC.Entidades
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        [Column("categoria_id")]
        public int CategoriaId;
        public string Nome;
        public string Descricao;
        public List<Produto> Produtos { get; set; }
    }
}
