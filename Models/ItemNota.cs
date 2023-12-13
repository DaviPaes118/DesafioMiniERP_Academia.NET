using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Models
{
    public class ItemNota
    {
        public int ItemNotaID { get; set; }
        public int NotaID { get; set; }
        virtual public Nota Nota { get; set; }
        public int ProdutoID { get; set; }
        virtual public Produto Produto { get; set; }
        [Required]
        public int Qtd { get; set; }
        [Column(TypeName = "decimal(18,2)"), Required]
        public decimal PrecoUnitario { get; set; }
    }
}
