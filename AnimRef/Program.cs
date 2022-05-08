using System;
using System.Collections.Generic;

namespace AnimRef
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomAnimalValue = 0;
            List<Animal> animalArray = new List<Animal>();
            for (int i = 0; i < 10; i++)
            {
                randomAnimalValue = rnd.Next(1, 5);

                if (randomAnimalValue == 1)
                {
                    animalArray.Add(new Bat());
                }
                else if (randomAnimalValue == 2)
                {
                    animalArray.Add(new Bee());
                }

                else if (randomAnimalValue == 3)
                {
                    animalArray.Add(new Cat());
                }

                else
                {
                    animalArray.Add(new Dog());
                }

                
            }

          

            foreach (Animal animal in animalArray)
            {
                Console.WriteLine($"{animal.ToString()}: {animal.Sound()}");
                
                if (animal is IMammal)
                {
                    Console.WriteLine($"Number of Nipples: {(animal as IMammal).NumberOfNipples}");
                    Console.WriteLine();
                }
                if (animal is ICanFly)
                {
                    Console.WriteLine($"Number of Wings: {(animal as ICanFly).NumberOfWings}");
                    Console.WriteLine();
                }
                    
            }
        }
    }
}
