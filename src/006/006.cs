﻿/*
    polymorphism
*/

namespace P006
{
    class Animal
    {
        public Animal()
        {

        }

        public virtual void animalSound()
        {
            System.Console.WriteLine("###");
        }

        public void sleep()
        {
            System.Console.WriteLine("Zzz");
        }
    }

    class Cat : Animal
    {
        public Cat() : base()
        {

        }

        public override void animalSound()
        {
            System.Console.WriteLine("miau");
        }
    }

    class Dog : Animal
    {
        public Dog() : base()
        {

        }

        public override void animalSound()
        {
            System.Console.WriteLine("wau wau");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal c = new Cat();
            Animal d = new Dog();

            a.animalSound();
            a.sleep();

            c.animalSound();
            c.sleep();

            d.animalSound();
            d.sleep();

            System.Console.ReadLine();
        }
    }
}
