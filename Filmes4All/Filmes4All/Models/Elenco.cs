using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Elenco
    {

        public Elenco()
        {
            ListaDeFilmes = new HashSet<Filmes>();
        }

        [Key]
        public int ID { get; set; }

        public string Realizador { get; set; }

        public string Ator1 { get; set; }

        public string Ator2 { get; set; }

        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe Filmes
        public virtual ICollection<Filmes> ListaDeFilmes { get; set; }
        //***********************************************************************

    }
}