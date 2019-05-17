using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IFuel
    {
        float Efficiency { get; }
        void Burn();
    }
}
