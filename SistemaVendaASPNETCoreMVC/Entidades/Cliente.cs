using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendaASPNETCoreMVC.Entidades
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("cliente_id")]
        public int? ClienteId { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public List<Venda> Vendas { get; set; }
    }
}
