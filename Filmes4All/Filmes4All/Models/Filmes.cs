using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Filmes
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }

        public string Descricao { get; set; }

        public string Capa { get; set; }

        public double Preco { get; set; }
    }
}