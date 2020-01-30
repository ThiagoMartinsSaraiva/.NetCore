using System;
using Animal.dto;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            AnimalDto animal = new AnimalDto();
            animal.Name = "Marry";
            animal.Age = 19;
            animal.Color = "Colorful";

            System.Console.WriteLine($"Name {animal.Name} age {animal.Age} color {animal.Color}");
            animal.Scream();
        }
    }
}
