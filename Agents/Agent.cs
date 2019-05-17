using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public abstract class Agent
    {
        public string Name { get; }

        public abstract char Move();

        public Agent(string name)
        {
            Name = name;
        }
    }
}
