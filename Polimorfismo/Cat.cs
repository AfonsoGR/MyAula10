using System;

namespace Polimorfismo
{
    public class Cat : Animal, IMammal
    {
        public override string Sound() => "Meow";

        int IMammal.NumberOfNipples => 6;
    }
}
