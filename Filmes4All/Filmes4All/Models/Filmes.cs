using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Filmes
    {

        public Filmes()
        {
            FilmesCarrinho = new HashSet<Carrinho>();
            ListaDeAtores = new HashSet<Elenco>();
            ListaDeEncomendas = new HashSet<Encomenda>();
            ListaDeEncomendasF = new HashSet<EncomendasFilmes>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public int Ano { get; set; }

        public string Descricao { get; set; }

        public string Capa { get; set; }

        public double PrecoVenda { get; set; }

        public double IMDB { get; set; }

        public virtual ICollection<Carrinho> FilmesCarrinho { get; set; }

        public virtual ICollection<Elenco> ListaDeAtores { get; set; }

        public virtual ICollection<Encomenda> ListaDeEncomendas { get; set; }

        public virtual ICollection<EncomendasFilmes> ListaDeEncomendasF { get; set; }

    }
}