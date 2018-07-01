using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Filmes
    {

        public Filmes()
        {
            FilmesCarrinho = new HashSet<Carrinho>();
            ListaDeFilmesParticipantes = new HashSet<FilmesParticipantes>();
            ListaDeEncomendasFilmes = new HashSet<EncomendasFilmes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//impede que um novo filme tenha um id automatico
        public int ID { get; set; }

        [Required(ErrorMessage = "o {0} é de preenchimento obrigatório!")] // o atributo nome é de preenchimento obrigatorio
        public string Titulo { get; set; }

        public int Ano { get; set; }

        public string Capa { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoVenda { get; set; }

        public double Pontuacao { get; set; }

       // public Participantes Participante { get; set; }

        public virtual ICollection<Carrinho> FilmesCarrinho { get; set; }

        public virtual ICollection<FilmesParticipantes> ListaDeFilmesParticipantes { get; set; }

        public virtual ICollection<EncomendasFilmes> ListaDeEncomendasFilmes { get; set; }

    }
}