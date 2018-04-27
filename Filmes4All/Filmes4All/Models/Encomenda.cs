using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Encomenda
    {

        public Encomenda()
        {
            ListaDeFilmesEncomendados = new HashSet<Filmes>();
            ListaDeFilmesE = new HashSet<EncomendasFilmes>();
        }

        [Key]
        public int ID { get; set; }

        public DateTime Data { get; set; }

        public double Desconto { get; set; }

        //FK Cliente
        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }


        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe Filmes
        public virtual ICollection<Filmes> ListaDeFilmesEncomendados { get; set; }
        //***********************************************************************

        public virtual ICollection<EncomendasFilmes> ListaDeFilmesE { get; set; }

    }
}