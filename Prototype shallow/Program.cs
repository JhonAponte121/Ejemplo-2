using System;

namespace Prototype_shallow
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal oAnimal = new Animal() { Nombre = "Oveja Dolly", Patas = 4 };
            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.Patas = 5;

            Console.WriteLine(oAnimal.Patas);
        }
    }
}
