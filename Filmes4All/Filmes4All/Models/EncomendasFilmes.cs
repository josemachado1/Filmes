using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class EncomendasFilmes
    {
        //Classe resultante do relacionamento Encomendas - Filmes, que contem os atributos do relacionamento

        // atributos específicos do relacionamento
        public int Quantidade { get; set; }

        public double PrecoCompra { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Encomendas
        //***********************************************************************
        [ForeignKey("Encomendas")]
        public Encomenda Encomenda { get; set; }
        public int EncomendasFK { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Filmes
        //***********************************************************************
        [ForeignKey("Filmes")]
        public Filmes Filme { get; set; }
        public int FilmesFK { get; set; }
        //***********************************************************************

    }
}