using System;

namespace Agents
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent[] agents = new Agent[] {new NPC("Zé"), new NPC("Manel"), new Player("Ti Jó")};

            foreach (Agent a in agents)
                Console.WriteLine(a + " , my movement is " + a.Move() + ".");
        }
    }
}
