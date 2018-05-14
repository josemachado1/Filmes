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


        public int ID { get; set; } // PK, por exigência da Entity Framework

        // atributos específicos do relacionamento
        public int Quantidade { get; set; }

        public double PrecoCompra { get; set; }

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Encomendas
        //***********************************************************************
        [ForeignKey("Encomenda")]  // A
        public int EncomendasFK { get; set; }  // B
        public virtual Encomenda Encomenda { get; set; }  // C

        //***********************************************************************
        // definição da chave forasteira (FK) que referencia a classe Filmes
        //***********************************************************************
        [ForeignKey("FilmesFK")]  // A
        public virtual Filmes Filme { get; set; }  // B
        public int FilmesFK { get; set; }  // C
        //***********************************************************************

    //    ( (A * B ) *  C ) 



    }
}