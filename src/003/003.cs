/*
    control structures
*/

namespace P003
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            //
            // if
            //

            if (x > 5)
            {
                System.Console.WriteLine("x is greater than 5");
            }

            //
            // if - else
            //

            if (x > 5)
            {
                System.Console.WriteLine("x is greater than 5");
            }
            else
            {
                System.Console.WriteLine("x is not greater than 5");
            }

            //
            // if - else if - else
            //

            if (x < 0)
            {
                System.Console.WriteLine("x is less than 0");
            }
            else if (x > 10)
            {
                System.Console.WriteLine("x is greater than 10");
            }
            else
            {
                System.Console.WriteLine("x is neither less than 0 nor greater than 10");
            }

            //
            // switch - case
            //

            x = 23;

            switch (x)
            {
                case 23:
                    System.Console.WriteLine("The answer is 23");
                    break;
                case 42:
                    System.Console.WriteLine("The answer is 42");
                    break;
                default:
                    System.Console.WriteLine("Unknown answer");
                    break;
            }

            //
            // while
            //

            x = 0;

            while (x < 10)
            {
                System.Console.WriteLine("This is run number: " + x );
                x = x + 1;
            }

            //
            // do - while
            //

            x = 0;

            do
            {
                System.Console.WriteLine("This is run number: " + x);
                x = x + 1;
            } while (x < 10);

            //
            // for
            //

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("This is run number: " + i);
            }

            //
            // foreach
            //

            string[] names = { "Isabella", "Emily", "Finn" };

            foreach (string name in names)
            {
                System.Console.WriteLine("Name: " + name);
            }

            //
            // break - continue
            //

            string[] friends = { "Alex", "Peter", "Anna", "Marta", "Elmo" };

            for (int i = 0; i< friends.Length; ++i)
            {
                if (friends[i] == "Peter")
                {
                    continue;
                }

                System.Console.WriteLine(friends[i]);

                if( i >= 3 )
                {
                    break;
                }
            }

            //
            // the end
            //

            System.Console.ReadLine();
        }
    }
}
