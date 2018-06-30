using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class Cliente
    {
        public Cliente()
        {
            ListaDeEncomendasClientes = new HashSet<Encomenda>();

            ListaDeCarrinho = new HashSet<Carrinho>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//impede que um novo filme tenha um id automatico
        public int ID { get; set; }

        [Required(ErrorMessage = "o {0} é de preenchimento obrigatório!")] // o atributo nome é de preenchimento obrigatorio
        public string Nome { get; set; }

        public string Telemovel { get; set; }

        public DateTime DataNascimento { get; set; }
        
        public string Morada { get; set; }

        public string CodPostal { get; set; }

                //********************************************************************************
        //criar uma FK para o utilizador autenticado

        public string UserName { get; set; }

        public virtual ICollection<Encomenda> ListaDeEncomendasClientes { get; set; }

        public virtual ICollection<Carrinho> ListaDeCarrinho { get; set; }





    }
}