using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Campeonato
    {
        private List<Time> _teams { get; set; } = new List<Time>();
        private List<Partida> _matches { get; set; } = new List<Partida>(); 
        private bool _startedTournament;

        public bool CriarTimes(List<Time> times, User user)
        {
            if (!user.CBF)
            {
                return false;
            }
            
            if (times.Count < 8 || times.Count % 2 != 0)
            {
                return false;
            }

            if (_startedTournament)
            {
                return false;
            }

            _startedTournament = true;
            _teams = times;
            
            return true;
        }

        public bool GerarPartidas(User user)
        {
            if (!user.CBF)
            {
                return false;
            }

            for (int i = 0; i < _teams.Count; i++)
            {
                for (int j = 0; j < _teams.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var Partida = new Partida(_teams[i],_teams[j]);
                    _matches.Add(Partida);
                }
            }
            
            return true;
        }

        public bool FazerGolsAPartida(User user, Guid timeCasa, Guid timeVisitante, List<(Jogador, int)> jogadores, int golsCasa, int golsVisitante)
        {
            if (!user.CBF)
            {
                return false;
            }
        
            var timeAnfitriao = _matches.FirstOrDefault(time => time.Home.Id == timeCasa).Home;
            timeAnfitriao.FazerGol(golsCasa);

            var timeFora = _matches.FirstOrDefault(time => time.Visitant.Id == timeVisitante).Visitant;
            timeFora.FazerGol(golsVisitante);

            // SetarTabela();
            GolsJogador(jogadores);
            return true;
        }

        private void GolsJogador(List<(Jogador jogador, int golsFeitos)> jogadores)
        {
            for (int i = 0; i < jogadores.Count; i++)
            {
                jogadores[i].jogador.FazerGol(jogadores[i].golsFeitos);
            }
        }

        public List<Jogador> Artilheiros()
        {
            var allPlayers = new List<Jogador>();
            
            for (int i = 0; i < _teams.Count; i++)
            {
                allPlayers.AddRange(_teams[i].Jogadores.Select(x => x));
            }

            var allPlayersGols = allPlayers.Select(player => player.Gols).ToList();
            allPlayersGols.Sort();
            int counter = allPlayersGols.Count - 1;
            var artilheiros = new List<Jogador>();

            for (int i = 0; i < 5; i++)
            {
                var temporary = allPlayers.FirstOrDefault(player => player.Gols == allPlayersGols[counter]);
                artilheiros.Add(temporary);
                counter--;
            }

            for (int i = allPlayersGols.Count - 1; i > allPlayersGols.Count - 6; i--)
            {
                var temporary = allPlayers.FirstOrDefault(player => player.Gols == allPlayersGols[i]);
                artilheiros.Add(temporary);
            }

            return artilheiros;
        }
    }
}