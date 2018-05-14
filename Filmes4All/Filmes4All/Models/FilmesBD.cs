using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Filmes4All.Models
{
    public class FilmesBD : DbContext
    {

        public FilmesBD() : base("FilmesBDConnectionString")
        {

        }


        public virtual DbSet<Carrinho> Carrinho { get; set; }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Elenco> Elenco { get; set; }

        public virtual DbSet<Encomenda> Encomenda { get; set; }

        public virtual DbSet<EncomendasFilmes> EncomendasFilmes { get; set; } // tabela que irá exprimir o relacionamento entre as classes Encomendas e Filmes

        public virtual DbSet<Filmes> Filmes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // impede a EF de 'pluralizar' os nomes das tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'

            base.OnModelCreating(modelBuilder);
        }



    }
}