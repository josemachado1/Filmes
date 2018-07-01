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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//impede que um novo cliente tenha um id automatico
        public int ID { get; set; }

        [StringLength(50)]
        [RegularExpression("[A-ZÁÂÉÍÓÚ][a-záàâãäèéêëìíîïòóôõöùúûüç]+((-| )((da|de|do|das|dos) )?[A-ZÁÂÉÍÓÚ][a-záàâãäèéêëìíîïòóôõöùúûüç]+)+", ErrorMessage = "O {0} é constituído apenas por letras e começa obrigatoriamente por uma maiúscula.")]
        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [StringLength(9)]
        [RegularExpression("[0-9]{9}", ErrorMessage = "O {0} deve ter 9 caracteres numéricos.")]
        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "A {0} é obrigatória!")]
        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage = "A {0} é obrigatória!")]
        public string Morada { get; set; }

        [StringLength(50)]
        [RegularExpression("[0-9]{4}-[0-9]{3}", ErrorMessage = "O {0} deve ter o formato 0000-000.")]
        [Required(ErrorMessage = "O {0} é obrigatório!")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

                //********************************************************************************
        //criar uma FK para o utilizador autenticado

        public string UserName { get; set; }

        public virtual ICollection<Encomenda> ListaDeEncomendasClientes { get; set; }

        public virtual ICollection<Carrinho> ListaDeCarrinho { get; set; }





    }
}