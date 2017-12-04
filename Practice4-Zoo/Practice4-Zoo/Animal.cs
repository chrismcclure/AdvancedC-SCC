using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_Zoo
{
    public abstract class Animal
    {

        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }

        public static int id = 1;

        public Animal(string name)
        {
            AnimalId = id;
            id++;
            Name = name;
        }
        //Honestly I didn't really understand how the program class was supposed to access the proctected methods.
        //So I made a public method in the animal class to take care off it.  
        public void Move() => Console.WriteLine($"{GetNameAndId()} is {Moving()} and could be {Communicate()}, but nothing else.");
        public void Noise() => Console.WriteLine($"{GetNameAndId()} is {Communicate()} and could be {Moving()}, but nothing else.");
        public void Sleep() => Console.WriteLine($"{GetNameAndId()} in {Sleeping()} and nothing else.");
        public void Eat() => Console.WriteLine($"{GetNameAndId()} in {Eating()} and nothing else.");

        protected abstract string Communicate();
        protected abstract string Moving();
        protected abstract string Sleeping();
        protected abstract string Eating();

        protected virtual string GetNameAndId()
        {
            return $"Id: {AnimalId}, {AnimalType}, Name: {Name}";
        }    
    }
}
