/*
    interface
*/

namespace P008
{
    interface IAnimal
    {
        void animalSound();
    }

    class Cat : IAnimal
    {
        public Cat() : base()
        {

        }

        public void animalSound()
        {
            System.Console.WriteLine("miau");
        }
    }

    class Dog : IAnimal
    {
        public Dog() : base()
        {

        }

        public void animalSound()
        {
            System.Console.WriteLine("wau wau");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();

            c.animalSound();
            d.animalSound();

            System.Console.ReadLine();
        }
    }
}
