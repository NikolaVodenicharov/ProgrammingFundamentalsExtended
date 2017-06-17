using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsProblem
{
    public class Dog
    {
        public string name;
        public int age;
        public int numberOfLegs;

        public Dog(string name, int age, int numberOfLegs)
        {
            this.name = name;
            this.age = age;
            this.numberOfLegs = numberOfLegs;
        }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }

        public override string ToString()
        {
            return $"Dog: {this.name}, Age: {this.age}, Number Of Legs: {this.numberOfLegs}";
        }
    }

    public class Cat
    {
        public string name;
        public int age;
        public int intelligenceQontient;

        public Cat (string name, int age, int intelligenceQontient)
        {
            this.name = name;
            this.age = age;
            this.intelligenceQontient = intelligenceQontient;
        }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }

        public override string ToString()
        {
            return $"Cat: {this.name}, Age: {this.age}, IQ: {this.intelligenceQontient}";
        }
    }

    public class Snake
    {
        public string name;
        public int age;
        public int crueltyCoefficient;

        public Snake (string name, int age, int crueltyCoefficient)
        {
            this.name = name;
            this.age = age;
            this.crueltyCoefficient = crueltyCoefficient;
        }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

        public override string ToString()
        {
            return $"Snake: {this.name}, Age: {this.age}, Cruelty: {this.crueltyCoefficient}";
        }
    }

    class AnimalsExecution
    {
        static void Main()
        {
            var dogs = new List<Dog>();
            var cats = new List<Cat>();
            var snakes = new List<Snake>();

            while (true)
            {
                var inputInfo = Console.ReadLine();

                var isTimeToStopLoop = inputInfo.Equals("I'm your Huckleberry", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var splitedInfo = inputInfo.Split();

                if (splitedInfo[0].Equals("talk", StringComparison.InvariantCultureIgnoreCase))
                {
                    ProduceSoundAccordingName(dogs, cats, splitedInfo);
                    continue;
                }

                AddAnimalToCollection(dogs, cats, snakes, splitedInfo);
            }

            PrintAnswer(dogs, cats, snakes);
        }

        private static void PrintAnswer(List<Dog> dogs, List<Cat> cats, List<Snake> snakes)
        {
            foreach (var d in dogs)
            {
                Console.WriteLine(d);
            }

            foreach (var c in cats)
            {
                Console.WriteLine(c);
            }

            foreach (var s in snakes)
            {
                Console.WriteLine(s);
            }
        }

        private static void AddAnimalToCollection(List<Dog> dogs, List<Cat> cats, List<Snake> snakes, string[] splitedInfo)
        {
            if (splitedInfo[0].Equals("Dog", StringComparison.InvariantCultureIgnoreCase))
            {
                var inputDog = new Dog(splitedInfo[1],
                                       int.Parse(splitedInfo[2]),
                                       int.Parse(splitedInfo[3]));
                dogs.Add(inputDog);
            }
            else if (splitedInfo[0].Equals("Cat", StringComparison.InvariantCultureIgnoreCase))
            {
                var inputCat = new Cat(splitedInfo[1],
                                       int.Parse(splitedInfo[2]),
                                       int.Parse(splitedInfo[3]));
                cats.Add(inputCat);
            }
            else
            {
                var inputSnake = new Snake(splitedInfo[1],
                                           int.Parse(splitedInfo[2]),
                                           int.Parse(splitedInfo[3]));
                snakes.Add(inputSnake);
            }
        }

        private static void ProduceSoundAccordingName(List<Dog> dogs, List<Cat> cats, string[] splitedInfo)
        {
            var nameOfAnimal = splitedInfo[1];
            if (dogs.Any(x => x.name.Equals(nameOfAnimal)))
            {
                Dog.ProduceSound();
            }
            else if (cats.Any(x => x.name.Equals(nameOfAnimal)))
            {
                Cat.ProduceSound();
            }
            else
            {
                Snake.ProduceSound();
            }
        }
    }
}
