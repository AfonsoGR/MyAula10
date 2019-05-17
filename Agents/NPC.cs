using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class NPC : Agent
    {
        private Random rng;
        private readonly char[] direction;

        public NPC(string name) : base(name)
        {
            direction = new char[] { 'N', 'W', 'E', 'S' };
            rng = new Random();
        }

        public override char Move()
        {
            int i = rng.Next(direction.Length);
            return direction[i];
        }

        public override string ToString() => 
            $"I´m a NPC and my name is {Name}";
    }
}
