using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class FilmesBD : DbContext
    {

        public FilmesBD() : base("FilmesBDConnectionString")
        {

        }


        public virtual ICollection<Carrinho> Carrinho { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual ICollection<Elenco> Elenco { get; set; }

        public virtual ICollection<Encomenda> Encomenda { get; set; }

        public virtual ICollection<EncomendasFilmes> EncomendasFilmes { get; set; } // tabela que irá exprimir o relacionamento entre as classes Encomendas e Filmes

        public virtual ICollection<Filmes> Filmes { get; set; }




    }
}