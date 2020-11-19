using System;

namespace Domain
{
    public class Partida
    {
        public Time Home { get; private set; }
        public Time Visitant { get; private set; }

        public Partida(Time home, Time visitant)
        {
            Home = home;
            
            Visitant = visitant;
        }
    }
}