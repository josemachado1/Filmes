using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Filmes4All.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("FilmesBDConnectionString", throwIfV1Schema: false)
        {
        }

        static ApplicationDbContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<ApplicationDbContext>(new ApplicationDbInitializer());
        }

        //juntar o codigo proveniente da classe FilmesBD

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Carrinho> Carrinho { get; set; }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Participantes> Participantes { get; set; }

        public virtual DbSet<Encomenda> Encomenda { get; set; }

        public virtual DbSet<EncomendasFilmes> EncomendasFilmes { get; set; } // tabela que irá exprimir o relacionamento entre as classes Encomendas e Filmes

        public virtual DbSet<Filmes> Filmes { get; set; }

        public virtual DbSet<FilmesParticipantes> FilmesParticipantes { get; set; } // tabela que irá exprimir o relacionamento entre as classes Participantes e Filmes



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  // impede a EF de 'pluralizar' os nomes das tabelas
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();  // força a que a chave forasteira não tenha a propriedade 'on delete cascade'

            base.OnModelCreating(modelBuilder);
        }


    }
}