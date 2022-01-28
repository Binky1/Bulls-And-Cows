using System;
using System.Linq;
using System.Threading;



namespace BullP
{


    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            BullPgiaa BP = new BullPgiaa();
            Random rnd = new Random();
            string guess = BP.GetGuess(); // Guess in random index
            int count = 1;

            Console.WriteLine($"Guess {count}: " + guess);
            Console.WriteLine("Bulls: ");
            int Bulls = int.Parse(Console.ReadLine());
            Console.WriteLine("Cows: ");
            int Cows = int.Parse(Console.ReadLine());
            while (Bulls != 4)
            {
                count++;
                BP.RemoveComb(Bulls, Cows);
                guess = BP.GetGuess();
                Console.WriteLine($"Guess {count}: " + guess); // Displays the current guess from the array
                Console.WriteLine("Bulls: ");
                Bulls = int.Parse(Console.ReadLine());
                Console.WriteLine("Cows: ");
                Cows = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine($"After {count} attempts, the number is: {guess}");
            Console.WriteLine("**************");
        }

        private static void Menu()
        {
            Console.WriteLine("Choose number with 4 different digits");
            Console.WriteLine("Nice");
            Console.WriteLine("Now write it down (on paper)");
            Console.WriteLine("****");
        }
    }
}