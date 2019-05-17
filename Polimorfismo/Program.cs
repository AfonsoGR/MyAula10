using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variáveis
            const int n = 10;

            // Inicializar arrays
            Animal[] animals = new Animal [n];
            Random rng = new Random();

            // Inicializar counteúdos do array
            for (int i = 0; i < n; i++)
            {
                switch (rng.Next(4))
                {
                    case 0: animals[i] = new Dog(); break;
                    case 1: animals[i] = new Cat(); break;
                    case 2: animals[i] = new Bat(); break;
                    case 3: animals[i] = new Bee(); break;
                }
            }

            // Percorrer array
            foreach (Animal a in animals)
            {
                string nipples = a is IMammal ? "\t-> Number of nipples = " + (a as IMammal).NumberOfNipples : "";
                string wings = a is ICanFly ? "\t-> Number of wings = " + (a as ICanFly).NumberOfWings : "";
                Console.WriteLine("\n" + a.Sound() + nipples + wings);
            }
        }
    }
}
