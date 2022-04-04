using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork___Task_3___Class_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task3");
            List<Animal> myAnimals = new List<Animal>()
            {
                new Animal() {Name = "Sparky", Color = "Brown", Age = 10, Gender = GenderEnum.Male},
                new Animal() { Name = "Joe", Color = "Black", Age = 8, Gender = GenderEnum.Female },
                new Animal() {Name = "Ricky", Color = "Brown", Age = 12, Gender = GenderEnum.Male},
                new Animal() {Name = "Johnny", Color = "Yellow", Age = 15, Gender = GenderEnum.Male},
                new Animal() {Name = "Ticky", Color = "Green", Age = 5, Gender = GenderEnum.Female},
                new Animal() {Name = "Ango", Color = "Black", Age = 13, Gender = GenderEnum.Female},
                new Animal() {Name = "Spang", Color = "Brown", Age = 8, Gender = GenderEnum.Male},

            };
            List<Animal> animalsAgedfive = myAnimals.Where(an => an.Age > 5).ToList();
            foreach(Animal animal in animalsAgedfive)
            {
                Console.WriteLine($"Animals Who's Age is bigger than 5: {animal.Name}");
            }
            List<Animal> animalsStartsWithA = myAnimals.Where(animal => animal.Name.StartsWith('A')).ToList();
            foreach(Animal animalWithA in animalsStartsWithA)
            {
                Console.WriteLine($"Animals With First Letter A: {animalWithA.Name}");
            }
            List<Animal> brownAnimalsMale = myAnimals.Where(animal => animal.Gender == GenderEnum.Male && animal.Color == "Brown").ToList();
            foreach(Animal animal in brownAnimalsMale)
            {
                Console.WriteLine($"All Brown Male Animals Are: {animal.Name}");
            }
            Animal firstAnimalWithLetterLongerThenTen = myAnimals.FirstOrDefault(animal => animal.Name.Length > 10);
        }
    }
}
