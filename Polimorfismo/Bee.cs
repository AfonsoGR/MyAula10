using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Bee : Animal, ICanFly
    {
        public override string Sound() => "Bzzzzzz";

        int ICanFly.NumberOfWings => 4;
    }
}
