using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Participantes
    {

        public Participantes()
        {
            ListaDeFilmesParticipantes = new HashSet<FilmesParticipantes>();
        }

        [Key]
        public int ID { get; set; }

        public string NomeParticipante { get; set; }

        public int IdadeParticipante { get; set; }


        public virtual ICollection<FilmesParticipantes> ListaDeFilmesParticipantes { get; set; }

    }
}