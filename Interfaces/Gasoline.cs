using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Gasoline : IFuel
    {
        public float Efficiency => 39.0f;

        public void Burn()
        {
            Console.WriteLine("Gas is bruning");
        }          
    }
}
