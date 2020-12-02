using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Time
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public List<Jogador> Jogadores { get; private set; } = new List<Jogador>();
        public int Gols { get; private set; } = 0;
        public int Vitorias { get; private set; } = 0;
        public int Empates { get; private set; } = 0;
        public int Derrotas { get; private set; } = 0;
        public int Pontos { get; private set; } = 0;
        public int GolsPro { get; private set; } = 0;
        public int GolsContra { get; private set; } = 0;
        public int SaldoDeGols { get; private set; } = 0;
        public int Aproveitamento { get; private set; } = 0;

        
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

        public void FazerGol(int golsFeitos)
        {
            Gols += golsFeitos;
        }
        
        public bool AdicionarJogadores(List<Jogador> jogadores)
        {
            if (jogadores.Count + Jogadores.Count > 32)
            {
                return false;
            }

            Jogadores.AddRange(jogadores);
            // Jogadores.AddRange(jogadores.Select(x => x));
            return true;
        }

        public bool RemoverJogadores(List<Jogador> jogadores)
        {
            if (jogadores.Count - Jogadores.Count < 16)
            {
                return false;
            }

            // for (int i = 0; i < Jogadores.Count; i++)
            // {
            //     for (int j = 0; j < Jogadores.Count; j++)
            //     {
            //         if (jogadores[j] == Jogadores[i])
            //         {
            //             Jogadores.Remove(jogadores[j]);
            //         }
            //     }
            // }

            for (int i = 0; i < jogadores.Count; i++)
            {
                var temporary = Jogadores.FirstOrDefault(player => player == jogadores[i]);
                Jogadores.Remove(temporary);
            }

            return true;
        }
    }
}