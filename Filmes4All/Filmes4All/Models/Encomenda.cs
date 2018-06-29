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
          //  ListaDeFilmesEncomendados = new HashSet<Filmes>();
            ListaDeEncomendasFilmes = new HashSet<EncomendasFilmes>();
        }

        [Key]
        public int ID { get; set; }

        public DateTime Data { get; set; }

        public double Desconto { get; set; }



        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe Filmes
        //***********************************************************************

        public virtual ICollection<EncomendasFilmes> ListaDeEncomendasFilmes { get; set; }

    }
}