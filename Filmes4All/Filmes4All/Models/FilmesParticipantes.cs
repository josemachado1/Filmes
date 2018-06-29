using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class FilmesParticipantes
    {
        public int ID { get; set; } // PK, por exigência da Entity Framework

        public string Tarefa { get; set; }

        public string Personagem { get; set; }


        [ForeignKey("FilmesFK")] 
        public virtual Filmes Filme { get; set; } 
        public int FilmesFK { get; set; }

        [ForeignKey("ParticipantesFK")]
        public virtual Participantes Particpante { get; set; }
        public int ParticipantesFK { get; set; }

    }

}