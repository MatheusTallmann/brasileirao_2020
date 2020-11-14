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

        public Time(string name)
        {
            Name = name;
        }

        public void CriarJogadores(List<Jogador> jogadores)
        {
            Jogadores = jogadores;
        }
    }
}