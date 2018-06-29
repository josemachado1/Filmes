using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Carrinho
    {
        [Key]
        public int ID { get; set; }

        public int Quantidade { get; set; }

        public double PrecoCompra { get; set; }
    
        //FK Filmes
        [ForeignKey("ClienteFK")]
        public virtual Cliente Cliente { get; set; }
        public int ClienteFK { get; set; }


    }
}