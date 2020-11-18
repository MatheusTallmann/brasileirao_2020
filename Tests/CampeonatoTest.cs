using System;
using System.Collections.Generic;
using Domain;
using Xunit;

namespace Tests
{
    public class CampeonatoTest
    {
        public List<Time> GerarTimes()
        {
            var userCBF = new User(1);
            
            //Elenco Palmeiras
            var Palmeiras1 = new Jogador("Weverton"); var Palmeiras2 = new Jogador("Marcos Rocha"); 
            var Palmeiras3 = new Jogador("Felipe M."); var Palmeiras4 = new Jogador("Vina"); 
            var Palmeiras5 = new Jogador("Wesley"); var Palmeiras6 = new Jogador("Vitor H."); 
            var Palmeiras7 = new Jogador("G. Gomez"); var Palmeiras8 = new Jogador("Patrick P");
            var Palmeiras9 = new Jogador("Willian."); var Palmeiras10 = new Jogador("L. Adriano");
            var Palmeiras11 = new Jogador("Rony"); var Palmeiras12 = new Jogador("Mayke");
            var Palmeiras13 = new Jogador("Luan");var Palmeiras14 = new Jogador("Zé Rafael");
            var Palmeiras15 = new Jogador("Ramires"); var Palmeiras16 = new Jogador("Lucas Esteves");
            
            var jogadoresPalmeiras = new List<Jogador>{Palmeiras1,Palmeiras2,Palmeiras3,Palmeiras4,Palmeiras5,Palmeiras6,Palmeiras7,
            Palmeiras8,Palmeiras9,Palmeiras10,Palmeiras11,Palmeiras12,Palmeiras13,Palmeiras14,Palmeiras15,Palmeiras16};
            
            //Elenco Corinthians
            var Corinthians1 = new Jogador("Cássio"); var Corinthians2 = new Jogador("Michel"); 
            var Corinthians3 = new Jogador("Gil"); var Corinthians4 = new Jogador("Lucas P."); 
            var Corinthians5 = new Jogador("Ramiro"); var Corinthians6 = new Jogador("Luan"); 
            var Corinthians7 = new Jogador("Cazares"); var Corinthians8 = new Jogador("Otero");
            var Corinthians9 = new Jogador("Jô"); var Corinthians10 = new Jogador("Léo Santos");
            var Corinthians11 = new Jogador("Sidcley"); var Corinthians12 = new Jogador("Boselli");
            var Corinthians13 = new Jogador("A. Araos"); var Corinthians14 = new Jogador("Léo Natel");
            var Corinthians15 = new Jogador("Camacho"); var Corinthians16 = new Jogador("M. Vital" );

            var jogadoresCorinthians = new List<Jogador>{Corinthians1,Corinthians2,Corinthians3,Corinthians4,Corinthians5,Corinthians6,Corinthians7,
            Corinthians8,Corinthians9,Corinthians10,Corinthians11,Corinthians12,Corinthians13,Corinthians14,Corinthians15,Corinthians16};
            
            //Elenco Santos
            var Santos1 = new Jogador("Vladimir"); var Santos2 = new Jogador("Luis Felipe");
            var Santos3 = new Jogador("Pará"); var Santos4 = new Jogador("Lucas Veríssimo");
            var Santos5 = new Jogador("Alison"); var Santos6 = new Jogador("Luan Peres");
            var Santos7 = new Jogador("Taílson"); var Santos8 = new Jogador("Jean Mota");
            var Santos9 = new Jogador("Carlos Sánchez"); var Santos10 = new Jogador("Soteldo");
            var Santos11 = new Jogador("Marinho"); var Santos12 = new Jogador("Jobson");
            var Santos13 = new Jogador("Madson"); var Santos14 = new Jogador("Kaio Jorge");
            var Santos15 = new Jogador("Anderson Ceará"); var Santos16 = new Jogador("Raniel");
            
            var jogadoresSantos = new List<Jogador>{Santos1,Santos2,Santos3,Santos4,Santos5,Santos6,Santos7,
            Santos8,Santos9,Santos10,Santos11,Santos12,Santos13,Santos14,Santos15,Santos16};
            
            //Elenco São Paulo
            var SaoPaulo1 = new Jogador("Tiago Volpi"); var SaoPaulo2 = new Jogador("Igor Vinicius");
            var SaoPaulo3 = new Jogador("Bruno Alves"); var SaoPaulo4 = new Jogador("Lucas Perri");
            var SaoPaulo5 = new Jogador("Arboleda"); var SaoPaulo6 = new Jogador("Reinaldo");
            var SaoPaulo7 = new Jogador("Hernanes"); var SaoPaulo8 = new Jogador("Jonas Toró");
            var SaoPaulo9 = new Jogador("Juanfran"); var SaoPaulo10 = new Jogador("Dani Alves");
            var SaoPaulo11 = new Jogador("Helinho"); var SaoPaulo12 = new Jogador("Pablo");
            var SaoPaulo13 = new Jogador("Brenner"); var SaoPaulo14 = new Jogador("Luciano");
            var SaoPaulo15 = new Jogador("Santiago Trellez"); var SaoPaulo16 = new Jogador("Léo");
            
            var jogadoresSaoPaulo = new List<Jogador>{SaoPaulo1,SaoPaulo2,SaoPaulo3,SaoPaulo4,SaoPaulo5,SaoPaulo6,SaoPaulo7,
            SaoPaulo8,SaoPaulo9,SaoPaulo10,SaoPaulo11,SaoPaulo12,SaoPaulo13,SaoPaulo14,SaoPaulo15,SaoPaulo16};

            //Elenco Flamengo
            var Flamengo1 = new Jogador("Diego Alves"); var Flamengo2 = new Jogador("Gustavo Henrique");
            var Flamengo3 = new Jogador("Rodrigo Caio"); var Flamengo4 = new Jogador("Léo Pereira");
            var Flamengo5 = new Jogador("Willian Arão"); var Flamengo6 = new Jogador("Renê");
            var Flamengo7 = new Jogador("Everton Ribeiro"); var Flamengo8 = new Jogador("Gerson");
            var Flamengo9 = new Jogador("G. Barbosa"); var Flamengo10 = new Jogador("Diego");
            var Flamengo11 = new Jogador("Vitinho"); var Flamengo12 = new Jogador("G. Arrascaeta");
            var Flamengo13 = new Jogador("Dudu"); var Flamengo14 = new Jogador("Pedro");
            var Flamengo15 = new Jogador("Bruno Henrique"); var Flamengo16 = new Jogador("Felipe Luis");

            var jogadoresFlamengo = new List<Jogador>{Flamengo1,Flamengo2,Flamengo3,Flamengo4,Flamengo5,Flamengo6,Flamengo7,
            Flamengo8,Flamengo9,Flamengo10,Flamengo11,Flamengo12,Flamengo13,Flamengo14,Flamengo15,Flamengo16};
            
            //Elenco Atlético MG
            var AtleticoMG1 = new Jogador("Everson"); var AtleticoMG2 = new Jogador("Gabriel V.");
            var AtleticoMG3 = new Jogador("Junior Alonso"); var AtleticoMG4 = new Jogador("Réver");
            var AtleticoMG5 = new Jogador("Alan Franco"); var AtleticoMG6 = new Jogador("Bueno");
            var AtleticoMG7 = new Jogador("Gustavo Blanco"); var AtleticoMG8 = new Jogador("Guilherme Arana");
            var AtleticoMG9 = new Jogador("Tardelli"); var AtleticoMG10 = new Jogador("Maílton");
            var AtleticoMG11 = new Jogador("Keno"); var AtleticoMG12 = new Jogador("Mariano");
            var AtleticoMG13 = new Jogador("Eduardo Sasha"); var AtleticoMG14 = new Jogador("Marquinhos");
            var AtleticoMG15 = new Jogador("Marrony"); var AtleticoMG16 = new Jogador("Savarino");

            var jogadoresAtleticoMG = new List<Jogador>{AtleticoMG1,AtleticoMG2,AtleticoMG3,AtleticoMG4,AtleticoMG5,AtleticoMG6,AtleticoMG7,
            AtleticoMG8,AtleticoMG9,AtleticoMG10,AtleticoMG11,AtleticoMG12,AtleticoMG13,AtleticoMG14,AtleticoMG15,AtleticoMG16};

            //Elenco Grêmio
            var Gremio1 = new Jogador("Paulo Victor"); var Gremio2 = new Jogador("Victor Ferraz");
            var Gremio3 = new Jogador("Geromel"); var Gremio4 = new Jogador("Kannemann");
            var Gremio5 = new Jogador("Robinho"); var Gremio6 = new Jogador("Léo Gomes");
            var Gremio7 = new Jogador("Matheus Henrique"); var Gremio8 = new Jogador("Maicon");
            var Gremio9 = new Jogador("Jean Pierre"); var Gremio10 = new Jogador("Pepê");
            var Gremio11 = new Jogador("Éverton"); var Gremio12 = new Jogador("Bruno Cortez");
            var Gremio13 = new Jogador("Diogo Barbosa"); var Gremio14 = new Jogador("David Braz");
            var Gremio15 = new Jogador("Darlan Mendes"); var Gremio16 = new Jogador("Lucas Silva");

            var jogadoresGremio = new List<Jogador>{Gremio1,Gremio2,Gremio3,Gremio4,Gremio5,Gremio6,Gremio7,
            Gremio8,Gremio9,Gremio10,Gremio11,Gremio12,Gremio13,Gremio14,Gremio15,Gremio16};

            //Elenco Internacional
            var Inter1 = new Jogador("Marcelo Lomba"); var Inter2 = new Jogador("Gabriel V.");
            var Inter3 = new Jogador("Victor Cuesta"); var Inter4 = new Jogador("Lucas Ribeiro");
            var Inter5 = new Jogador("Rodrigo Moledo"); var Inter6 = new Jogador("Uendel");
            var Inter7 = new Jogador("Patrick"); var Inter8 = new Jogador("Moisés");
            var Inter9 = new Jogador("Nonato"); var Inter10 = new Jogador("Heitor");
            var Inter11 = new Jogador("Jussa"); var Inter12 = new Jogador("D'Alessandro");
            var Inter13 = new Jogador("Rodrigo Dourado"); var Inter14 = new Jogador("Willian Pottker");
            var Inter15 = new Jogador("Gabriel Boschilia"); var Inter16 = new Jogador("Tiago Galhardo");
            
            var jogadoresInter = new List<Jogador>{Inter1,Inter2,Inter3,Inter4,Inter5,Inter6,Inter7,
            Inter8,Inter9,Inter10,Inter11,Inter12,Inter13,Inter14,Inter15,Inter16};

            var timeInter = new Time("Internacional", userCBF); timeInter.CriarJogadores(jogadoresInter);
            var timeGremio = new Time("Grêmio", userCBF); timeGremio.CriarJogadores(jogadoresGremio);
            var timeAlteticoMG = new Time("Atlético MG", userCBF); timeAlteticoMG.CriarJogadores(jogadoresAtleticoMG);
            var timeFlamengo = new Time("Flamengo", userCBF); timeFlamengo.CriarJogadores(jogadoresFlamengo);
            var timeSaoPaulo = new Time("São Paulo", userCBF); timeSaoPaulo.CriarJogadores(jogadoresSaoPaulo);
            var timeSantos = new Time("Santos", userCBF); timeSantos.CriarJogadores(jogadoresSantos);
            var timeCorinthians = new Time("Corinthians", userCBF); timeCorinthians.CriarJogadores(jogadoresCorinthians);
            var timePalmeiras = new Time("Palmeiras", userCBF); timePalmeiras.CriarJogadores(jogadoresPalmeiras);

            return new List<Time>{timeInter,timeAlteticoMG,timeCorinthians,timeFlamengo,timeGremio,timePalmeiras,timeSantos,timeSaoPaulo};
        }


        [Fact]
        public void Should_Create_Teams_If_User_Is_CBF()
        {
            // Dado / Setup
            var campeonato = new Campeonato();
            var userCBF = new User(1);

            // Quando / Ação
            var created = campeonato.CriarTimes(GerarTimes(), userCBF);

            // Deve / Asserções
            Assert.True(created);
        }

        [Fact]
        public void Shouldnt_Create_Teams_If_User_Is_Torcedor()
        {
            // Dado / Setup
            var campeonato = new Campeonato();
            var userCBF = new User(0);
            
            // Quando / Ação
            var created = campeonato.CriarTimes(GerarTimes(), userCBF);

            // Deve / Asserções
            Assert.False(created);
        }

        [Fact]
        public void Shouldnt_Create_Teams_If_Have_More_Then_Eight_Teams()
        {
            // Dado / Setup
            var campeonato = new Campeonato();
            var userCBF = new User(1);
            var cruzeiro = new Time("Cruzeiro", userCBF);
            var times = GerarTimes();
            times.Add(cruzeiro);

            // Quando / Ação
            var created = campeonato.CriarTimes(times, userCBF);

            // Deve / Asserções
            Assert.False(created);
        }

        [Fact]
        public void Shouldnt_Create_Teams_If_Have_Six_Teams()
        {
            // Dado / Setup
            var campeonato = new Campeonato();
            var userCBF = new User(1);
            var times = GerarTimes();
            times.RemoveAt(3);
            times.RemoveAt(4);

            // Quando / Ação
            var created = campeonato.CriarTimes(times, userCBF);

            // Deve / Asserções
            Assert.False(created);
        }
    }
}
