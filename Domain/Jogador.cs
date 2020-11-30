using System;

namespace Domain
{
    public class Jogador
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public int Gols { get; private set; } = 0;

        public Jogador(string name)
        {
            Name = name;
        }

        public void FazerGol(int golsFeitos)
        {
            Gols += golsFeitos;
        }
    }
}