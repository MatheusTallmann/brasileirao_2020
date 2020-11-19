using System;
using System.Collections.Generic;

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

        public bool GerarPartida(User user)
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

        public bool FazerGolsAPartida(User user)
        {
            if (!user.CBF)
            {
                return false;
            }

            
        }
    }
}