using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class Player : Agent
    {
        public Player(string name) : base(name) { }

        public override char Move()
        {
            Console.WriteLine("Choose a direction. N,S,W,E");
            return Console.ReadLine().ToUpper()[0];
        }

        public override string ToString()
        {
            return $"I´m a Player and my name is {Name}";
        }
    }
}
