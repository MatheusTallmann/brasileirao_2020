using System;
using System.Collections.Generic;

namespace Domain
{
    public class Time
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public List<Jogador> Jogadores { get; private set; } = new List<Jogador>();
        public int Gols { get; private set; } = 0;

        public Time(string name, User user)
        {
            if (user.CBF)
            {
                Name = name;
            }
        }

        public bool CriarJogadores(List<Jogador> jogadores)
        {
            if (jogadores.Count < 16 || jogadores.Count > 32)
            {
                return false;
            }

            Jogadores = jogadores;
            return true;
        }
    }
}