using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Models
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CNPJ { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
