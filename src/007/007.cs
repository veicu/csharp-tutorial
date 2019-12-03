/*
    abstraction
*/

namespace P007
{
    abstract class Animal
    {
        public Animal()
        {

        }

        public abstract void animalSound();

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
            /*
            Animal a = new Animal(); // Cannot create an instance of abstract class
            */

            Animal c = new Cat();
            Animal d = new Dog();

            c.animalSound();
            c.sleep();

            d.animalSound();
            d.sleep();

            System.Console.ReadLine();
        }
    }
}
