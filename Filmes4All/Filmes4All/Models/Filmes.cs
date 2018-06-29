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
            ListaDeEncomendasFilmes = new HashSet<EncomendasFilmes>();
        }

        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "o {0} é de preenchimento obrigatório!")] // o atributo nome é de preenchimento obrigatorio
        public string Titulo { get; set; }

        public int Ano { get; set; }

        public string Capa { get; set; }

        public string Descricao { get; set; }

        public double PrecoVenda { get; set; }

        public double Pontuacao { get; set; }



        public virtual ICollection<Carrinho> FilmesCarrinho { get; set; }

        public virtual ICollection<Elenco> ListaDeAtores { get; set; }

        public virtual ICollection<EncomendasFilmes> ListaDeEncomendasFilmes { get; set; }

    }
}