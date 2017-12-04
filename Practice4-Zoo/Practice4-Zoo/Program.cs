using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Lion("Leo"));
            animals.Add(new Lion("Rambo"));
            animals.Add(new Lion("Twitter"));
            animals.Add(new Bird("Tums"));
            animals.Add(new Bird("Superman"));

            Communicate(animals);     
            Moving(animals);
            Sleeping(animals);
            Eating(animals);

            Console.ReadLine();
        }


        public static void Communicate(List<Animal> animals)
        {
            Console.WriteLine("\nCommunicating");
            foreach (Animal animal in animals)
            {
                animal.Noise();
            }
        }

        public static void Moving(List<Animal> animals)
        {
            Console.WriteLine("\nMoving");
            foreach (Animal animal in animals)
            {
                animal.Move();
            }
        }

        public static void Sleeping(List<Animal> animals)
        {
            Console.WriteLine("\nSleeping");
            foreach (Animal animal in animals)
            {
                animal.Sleep();
            }
        }

        public static void Eating(List<Animal> animals)
        {
            Console.WriteLine("\nEating");
            foreach (Animal animal in animals)
            {
                animal.Eat();
            }
        }
    }
}
