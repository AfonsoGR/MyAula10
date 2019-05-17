using System;

namespace Polimorfismo
{
    public class Dog : Animal, IMammal
    {
        public override string Sound() => "Woof!";

        int IMammal.NumberOfNipples => 8;
    }
}
