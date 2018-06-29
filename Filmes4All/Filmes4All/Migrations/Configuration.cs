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



            //*********************************************************************
            // adiciona PARTICIPANTES
            var participantes = new List<Participantes> {
   new Participantes {ID=1, NomeParticipante="Saoirse Ronan",IdadeParticipante=1},
   new Participantes {ID=2, NomeParticipante="Daniel Kaluuya",IdadeParticipante=2},
   new Participantes {ID=3, NomeParticipante="Fionn Whitehead",IdadeParticipante=3},
   new Participantes {ID=4, NomeParticipante="Anthony Gonzalez",IdadeParticipante=4},
   new Participantes {ID=5, NomeParticipante="Kumail Nanjiani",IdadeParticipante=5},
   new Participantes {ID=6, NomeParticipante="Gal Gadot",IdadeParticipante=6},
   new Participantes {ID=7, NomeParticipante="Hugh Jackman",IdadeParticipante=7},
   new Participantes {ID=8, NomeParticipante="Daisy Ridley",IdadeParticipante=8},
   new Participantes {ID=9, NomeParticipante="Sally Hawkins",IdadeParticipante=9},
   new Participantes {ID=10, NomeParticipante="Brooklynn Prince",IdadeParticipante=10}
};
            participantes.ForEach(pp => context.Participantes.AddOrUpdate(p => p.ID, pp));
            context.SaveChanges();


            //*********************************************************************
            // adiciona FILMESPARTICIPANTES
            var filmesPart = new List<FilmesParticipantes> {
   new FilmesParticipantes {ID=1, Tarefa="Actor" ,Personagem="Lady Bird McPherson",FilmesFK=1,ParticipantesFK=1},
   new FilmesParticipantes {ID=2, Tarefa="Actor" ,Personagem="Chris Washington",FilmesFK=2,ParticipantesFK=2},
   new FilmesParticipantes {ID=3, Tarefa="Actor" ,Personagem="Tommy",FilmesFK=3,ParticipantesFK=3},
   new FilmesParticipantes {ID=4, Tarefa="Actor" ,Personagem="Miguel",FilmesFK=4,ParticipantesFK=4},
   new FilmesParticipantes {ID=5, Tarefa="Actor" ,Personagem="Kumail",FilmesFK=5,ParticipantesFK=5},
   new FilmesParticipantes {ID=6, Tarefa="Actor" ,Personagem="Diana",FilmesFK=6,ParticipantesFK=6},
   new FilmesParticipantes {ID=7, Tarefa="Actor" ,Personagem="Logan",FilmesFK=7,ParticipantesFK=7},
   new FilmesParticipantes {ID=8, Tarefa="Actor" ,Personagem="Rey",FilmesFK=8,ParticipantesFK=8},
   new FilmesParticipantes {ID=9, Tarefa="Actor" ,Personagem="Elisa Esposito",FilmesFK=9,ParticipantesFK=9},
   new FilmesParticipantes {ID=10, Tarefa="Actor" ,Personagem="Moonee",FilmesFK=10,ParticipantesFK=10}
};
            filmesPart.ForEach(pp => context.FilmesParticipantes.AddOrUpdate(p => p.ID, pp));
            context.SaveChanges();




            //*********************************************************************
            // adiciona Cliente
            var cliente = new List<Cliente> {
   new Cliente {ID=1, Nome=" João Santos", Telemovel="912039720", DataNascimento=new DateTime(1965,2,21), Morada="Praceta Conde Arnoso 98 - Lisboa", CodPostal="2610-043" },
   new Cliente {ID=2, Nome=" Daniel Soares", Telemovel="928155823", DataNascimento=new DateTime(1966,7,19), Morada="R Principal 107 - Guarda", CodPostal="6270-107"  },
   new Cliente {ID=3, Nome=" Adriana Rodrigues", Telemovel="922775155", DataNascimento=new DateTime(1981,12,3), Morada="Avenida Julio S Dias 55 - Porto", CodPostal="4480-673"  },
   new Cliente {ID=4, Nome=" Rosa Fernandes", Telemovel="913055221", DataNascimento=new DateTime(1977,9,24), Morada="Rua Telheiro 104 - Setubal", CodPostal="2901-901"  },
   new Cliente {ID=5, Nome=" Carolina Oliveira", Telemovel="938070118", DataNascimento=new DateTime(1953,8,17), Morada="R Centieira 26 - Coimbra", CodPostal="3420-341"  },
   new Cliente {ID=6, Nome=" César Sousa", Telemovel="916118589", DataNascimento=new DateTime(1964,8,22), Morada="Avenida Visconde Valmor 14 - Lisboa", CodPostal="1000-291"  }

};
            cliente.ForEach(cc => context.Cliente.AddOrUpdate(c => c.ID, cc));
            context.SaveChanges();


            //*********************************************************************
            // adiciona Encomedas
            var encomenda = new List<Encomenda> {
   new Encomenda {ID=1, Data=new DateTime(2018,2,21), Desconto=20},
   new Encomenda {ID=2, Data=new DateTime(2017,7,19), Desconto=10},
   new Encomenda {ID=3, Data=new DateTime(2017,12,3), Desconto=15},
   new Encomenda {ID=4, Data=new DateTime(2017,9,24), Desconto=30},
   new Encomenda {ID=5, Data=new DateTime(2017,8,17), Desconto=5},
   new Encomenda {ID=6, Data=new DateTime(2017,8,22), Desconto=25}

};
            encomenda.ForEach(ee => context.Encomenda.AddOrUpdate(e => e.ID, ee));
            context.SaveChanges();






            //*********************************************************************
            // adiciona EncomedasFilmes
            var encFilm = new List<EncomendasFilmes> {
   new EncomendasFilmes {ID=1, Quantidade=1 ,PrecoCompra=5,EncomendasFK=1,FilmesFK=1 },
   new EncomendasFilmes {ID=2, Quantidade=2 ,PrecoCompra=10,EncomendasFK=2,FilmesFK=2},
   new EncomendasFilmes {ID=3, Quantidade=1 ,PrecoCompra=5,EncomendasFK=3,FilmesFK=3},
   new EncomendasFilmes {ID=4, Quantidade=3 ,PrecoCompra=15,EncomendasFK=4,FilmesFK=4 },
   new EncomendasFilmes {ID=5, Quantidade=1 ,PrecoCompra=5,EncomendasFK=5,FilmesFK=5},
   new EncomendasFilmes {ID=6, Quantidade=2 ,PrecoCompra=10,EncomendasFK=6,FilmesFK=6 }

};
            encFilm.ForEach(ecf => context.EncomendasFilmes.AddOrUpdate(ef => ef.ID, ecf));
            context.SaveChanges();



            //*********************************************************************
            // adiciona Carrinho
            var carrinho = new List<Carrinho> {
   new Carrinho {ID=1, Quantidade=1, PrecoCompra=5,ClienteFK=1},
   new Carrinho {ID=2, Quantidade=5, PrecoCompra=5,ClienteFK=2},
   new Carrinho {ID=3, Quantidade=3, PrecoCompra=5,ClienteFK=3},
   new Carrinho {ID=4, Quantidade=6, PrecoCompra=5,ClienteFK=4},
   new Carrinho {ID=5, Quantidade=2, PrecoCompra=5,ClienteFK=5},
   new Carrinho {ID=6, Quantidade=4, PrecoCompra=5,ClienteFK=6},

};
            carrinho.ForEach(car => context.Carrinho.AddOrUpdate(ca => ca.ID, car));
            context.SaveChanges();


        }
    }
}
