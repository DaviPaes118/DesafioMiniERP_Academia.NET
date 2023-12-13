using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Models
{
    public class Nota
    {
        public int NotaID { get; set; }
        [Required]
        public int ClienteID { get; set; }
        virtual public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        virtual public ICollection<ItemNota> Itens { get; set; }
    }
}
