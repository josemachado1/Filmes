namespace Filmes4All.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Filmes4All.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //*********************************************************************
            // adiciona FILMES
            var filmes = new List<Filmes> {
   new Filmes {ID=1, Titulo="Lady Bird", Ano=2017, Capa="Ladybird.jpg", Descricao="Christine McPherson está no último ano do colégio e o que mais deseja é ir fazer faculdade longe de Sacramento, Califórnia, ideia rejeitada por sua mãe. Lady Bird, como a garota de forte personalidade exige ser chamada, não se dá por vencida e leva o plano de ir embora adiante mesmo assim. Enquanto a hora não chega, ela se divide entre as obrigações estudantis no colégio católico, o primeiro namoro, típicos rituais de passagem para a vida adulta e inúmeros desentendimentos com a progenitora.", PrecoVenda=5, Pontuacao=7.5 },
   new Filmes {ID=2, Titulo="Foge", Ano=2017, Capa="Foge.jpg", Descricao="Um jovem fotógrafo descobre um segredo sombrio quando conhece os pais aparentemente amigáveis da sua namorada.", PrecoVenda=5, Pontuacao=7.7 },
   new Filmes {ID=3, Titulo="Dunkirk", Ano=2017, Capa="Dunkirk.jpg", Descricao="Durante a Segunda Guerra Mundial, a Alemanha avança rumo à França e cerca as tropas aliadas nas praias de Dunkirk. Sob cobertura aérea e terrestre das forças britânicas e francesas, as tropas são lentamente evacuadas da praia.", PrecoVenda=5, Pontuacao=8.0 },
   new Filmes {ID=4, Titulo="Coco", Ano=2017, Capa="Coco.jpg", Descricao="Miguel é um menino de 12 anos que deseja ser um músico famoso, mas precisa lidar com sua família que desaprova seu sonho. Determinado a virar o jogo, ele acaba desencadeando uma série de eventos ligados a um mistério de 100 anos.", PrecoVenda=5, Pontuacao=8.5 },
   new Filmes {ID=5, Titulo="Amor de Improviso", Ano=2017, Capa="AmorDeImproviso.jpg", Descricao="O comediante paquistanês Kumail e a estudante de graduação Emily se apaixonam, mas encontram dificuldades quando suas culturas entram em conflito.", PrecoVenda=5, Pontuacao=7.6 },
   new Filmes {ID=6, Titulo="Mulher-Maravilha", Ano=2017, Capa="Mulher_Maravilha.jpg", Descricao="Treinada desde cedo para ser uma guerreira imbatível, Diana Prince nunca saiu da paradisíaca ilha em que é reconhecida como princesa das Amazonas. Quando o piloto Steve Trevor se acidenta e cai em uma praia do local, ela descobre que uma guerra sem precedentes está se espalhando pelo mundo e decide deixar seu lar certa de que pode parar o conflito. Lutando para acabar com todas as lutas, Diana percebe o alcance de seus poderes e sua verdadeira missão na Terra.", PrecoVenda=5, Pontuacao=7.5 },
   new Filmes {ID=7, Titulo="Logan", Ano=2017, Capa="Logan.jpg", Descricao="Em 2024, os mutantes estão em franco declínio, e as pessoas não sabem o real motivo. Uma organização está transformando as crianças mutantes em verdadeiras assassinas. Wolverine, cansado de tudo e a pedido de um cada vez mais enfraquecido Professor Xavier, precisa proteger a jovem e poderosa Laura Kinney, conhecida como X-23. Enquanto isso, o vilão Nathaniel Essex amplia seu projeto de destruição.", PrecoVenda=5, Pontuacao=8.1 },
   new Filmes {ID=8, Titulo="Star Wars: Episódio VIII - Os Últimos Jedi", Ano=2017, Capa="SW_TLJ.jpg", Descricao="A tranquila e solitária vida de Luke Skywalker sofre uma reviravolta quando ele conhece Rey, uma jovem que mostra fortes sinais da Força. O desejo dela de aprender o estilo dos Jedi força Luke a tomar uma decisão que mudará sua vida para sempre. Enquanto isso, Kylo Ren e o General Hux lideram a Primeira Ordem para um ataque total contra Leia e a Resistência pela supremacia da galáxia.", PrecoVenda=5, Pontuacao=7.3 },
   new Filmes {ID=9, Titulo="A Forma da Água", Ano=2017, Capa="A_Forma_da_Agua.jpg", Descricao="Elisa é uma zeladora muda que trabalha em um laboratório onde um homem anfíbio está sendo mantido em cativeiro. Quando Elisa se apaixona com a criatura, ela elabora um plano para ajudá-lo a escapar com a ajuda de seu vizinho.", PrecoVenda=5, Pontuacao=7.4 },
   new Filmes {ID=10, Titulo="The Florida Project", Ano=2017, Capa="The_Florida_Project.jpg", Descricao="Moonee, uma agitada garotinha, faz novas amizades nas redondezas dos parques Disney. Ela vive com a mãe em uma hospedagem de beira de estrada e as duas contam com a proteção do gerente Bobby na batalha diária pela sobrevivência.", PrecoVenda=5, Pontuacao=7.6 }
};
            filmes.ForEach(ff => context.Filmes.AddOrUpdate(f => f.Titulo, ff));
            context.SaveChanges();

/*
            //*********************************************************************
            // adiciona ELENCO
            var elenco = new List<Elenco> {
   new Elenco {ID=1, Realizador="Greta Gerwig", Ator1="Saoirse Ronan", Ator2="Laurie Metcalf",FilmeFK=1},
   new Elenco {ID=2, Realizador="Jordan Peele", Ator1="Daniel Kaluuya", Ator2="Allison Williams",FilmeFK=2},
   new Elenco {ID=3, Realizador="Christopher Nolan", Ator1="Fionn Whitehead", Ator2="Barry Keoghan",FilmeFK=3},
   new Elenco {ID=4, Realizador="Lee Unkrich", Ator1="Anthony Gonzalez", Ator2="Gael García Bernal",FilmeFK=4},
   new Elenco {ID=5, Realizador="Michael Showalter", Ator1="Kumail Nanjiani", Ator2="Zoe Kazan",FilmeFK=5},
   new Elenco {ID=6, Realizador="Patty Jenkins", Ator1="Gal Gadot", Ator2="Chris Pine",FilmeFK=6},
   new Elenco {ID=7, Realizador="James Mangold", Ator1="Hugh Jackman", Ator2="Patrick Stewart",FilmeFK=7},
   new Elenco {ID=8, Realizador="Rian Johnson", Ator1="Daisy Ridley", Ator2="John Boyega",FilmeFK=8},
   new Elenco {ID=9, Realizador="Guillermo del Toro", Ator1="Sally Hawkins", Ator2="Octavia Spencer",FilmeFK=9},
   new Elenco {ID=10, Realizador="Sean Baker", Ator1="Brooklynn Prince", Ator2="Bria Vinaite",FilmeFK=10},
};
            elenco.ForEach(ee => context.Elenco.AddOrUpdate(e => e.ID, ee));
            context.SaveChanges();

  */      
            //*********************************************************************
            // adiciona Cliente
            var cliente = new List<Cliente> {
   new Cliente {ID=1, Nome=" João Santos", Telemovel="912039720", DataNascimento=new DateTime(1965,2,21), Morada="Praceta Conde Arnoso 98 - Lisboa", UserName="noEmail@mail.pt" },
   new Cliente {ID=2, Nome=" Daniel Soares", Telemovel="928155823", DataNascimento=new DateTime(1966,7,19), Morada="R Principal 107 - Guarda", UserName="danielSoares@mail.pt" },
   new Cliente {ID=3, Nome=" Adriana Rodrigues", Telemovel="922775155", DataNascimento=new DateTime(1981,12,3), Morada="Avenida Julio S Dias 55 - Porto", UserName="noEmail@mail.pt" },
   new Cliente {ID=4, Nome=" Rosa Fernandes", Telemovel="913055221", DataNascimento=new DateTime(1977,9,24), Morada="Rua Telheiro 104 - Setubal", UserName="noEmail@mail.pt" },
   new Cliente {ID=5, Nome=" Carolina Oliveira", Telemovel="938070118", DataNascimento=new DateTime(1953,8,17), Morada="R Centieira 26 - Coimbra", UserName="noEmail@mail.pt" },
   new Cliente {ID=6, Nome=" César Sousa", Telemovel="916118589", DataNascimento=new DateTime(1964,8,22), Morada="Avenida Visconde Valmor 14 - Lisboa", UserName="noEmail@mail.pt" }

};
            cliente.ForEach(cc => context.Cliente.AddOrUpdate(c => c.ID, cc));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Encomedas
            var encomenda = new List<Encomenda> {
   new Encomenda {ID=1, Data=new DateTime(2018,2,21), Desconto=20, ClienteFK=1 },
   new Encomenda {ID=2, Data=new DateTime(2017,7,19), Desconto=10, ClienteFK=2 },
   new Encomenda {ID=3, Data=new DateTime(2017,12,3), Desconto=15, ClienteFK=3 },
   new Encomenda {ID=4, Data=new DateTime(2017,9,24), Desconto=30, ClienteFK=4 },
   new Encomenda {ID=5, Data=new DateTime(2017,8,17), Desconto=5, ClienteFK=5 },
   new Encomenda {ID=6, Data=new DateTime(2017,8,22), Desconto=25, ClienteFK=6 }

};
            encomenda.ForEach(ecc => context.Encomenda.AddOrUpdate(ec => ec.ID, ecc));
            context.SaveChanges();



            //*********************************************************************
            // adiciona Carrinho
            var carrinho = new List<Carrinho> {
   new Carrinho {ID=1, Quantidade=1, PrecoCompra=5},
   new Carrinho {ID=2, Quantidade=5, PrecoCompra=5},
   new Carrinho {ID=3, Quantidade=3, PrecoCompra=5},
   new Carrinho {ID=4, Quantidade=6, PrecoCompra=5},
   new Carrinho {ID=5, Quantidade=2, PrecoCompra=5},
   new Carrinho {ID=6, Quantidade=4, PrecoCompra=5}

};
            carrinho.ForEach(car => context.Carrinho.AddOrUpdate(ca => ca.ID, car));
            context.SaveChanges();


        }
    }
}
