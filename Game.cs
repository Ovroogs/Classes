using System;

namespace Classes
{
    class Game
    {
        public string Name;
        public string Genre;
        public string Developer;
        public int Age;

        public Game() : this("Doom")
        { }
        public Game(string n) : this(n, "шутер от первого лица")
        { }
        public Game(string n, string g):this(n, g, " id Software, Midway Games,Nerve Software")
        { }
        public Game(string n, string g, string d) : this(n, g, d, 1993)
        { }
        public Game(string n, string g, string d, int a)
        {
            Name = n;
            Genre = g;
            Age = a;
            Developer = d;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}; Gener: {Genre}; Developer:{Developer} Age: {Age}.");
        }

    }
}