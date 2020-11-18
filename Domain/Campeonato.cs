using System;
using System.Collections.Generic;

namespace Domain
{
    public class Campeonato
    {
        private List<Time> _teams { get; set; } = new List<Time>();
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
    }
}