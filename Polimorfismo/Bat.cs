using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound() => "*sounds of echo location*";

        int IMammal.NumberOfNipples => 2;
        int ICanFly.NumberOfWings => 2;
    }
}
