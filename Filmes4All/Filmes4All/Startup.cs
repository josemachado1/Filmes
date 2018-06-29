using Filmes4All.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;

namespace Filmes4All
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            iniciaAplicacao();
        }


        /// <summary>
        /// cria, caso não existam, as Roles de suporte à aplicação: Veterinario, Funcionario, Dono
        /// cria, nesse caso, também, um utilizador...
        /// </summary>
        private void iniciaAplicacao()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // criar a Role 'Clente'
            if (!roleManager.RoleExists("Cliente"))
            {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Cliente";
                roleManager.Create(role);
            }



            // criar a Role 'Admin'
            if (!roleManager.RoleExists("Admin"))
            {
                // não existe a 'role'
                // então, criar essa role
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }



            // criar um utilizador 'Cliente'
            var user = new ApplicationUser();
            user.UserName = "danielSoares@mail.pt";
            user.Email = "danielSoares@mail.pt";
            string userPWD = "123_Asd";
            var chkUser = userManager.Create(user, userPWD);

            //Adicionar o Utilizador à respetiva Role-Agente-
            if (chkUser.Succeeded)
            {
                var result1 = userManager.AddToRole(user.Id, "Cliente");
            }



            // criar um utilizador 'Admin'
             user = new ApplicationUser();
            user.UserName = "admin@mail.pt";
            user.Email = "admin@mail.pt";
             userPWD = "123_Asd";
             chkUser = userManager.Create(user, userPWD);

            //Adicionar o Utilizador à respetiva Role-Agente-
            if (chkUser.Succeeded)
            {
                var result1 = userManager.AddToRole(user.Id, "Admin");
            }



        }


    }
}
