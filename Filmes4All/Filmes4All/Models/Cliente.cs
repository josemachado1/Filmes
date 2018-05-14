using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Cliente
    {
        public Cliente()
        {
            ListaDeEncomendasClientes = new HashSet<Encomenda>();
        }


        [Key]

        public int ID { get; set; }

        [Required(ErrorMessage = "o {0} é de preenchimento obrigatório!")] // o atributo nome é de preenchimento obrigatorio
        public string Nome { get; set; }

        public string Telemovel { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public string Morada { get; set; }

        public virtual ICollection<Encomenda> ListaDeEncomendasClientes { get; set; }
    }
}