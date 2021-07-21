using System;

namespace WhileLoopsChallenge_Brackeys
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int attempts = 0;
            int roll = 0;

            Console.WriteLine("Press enter to roll the dice");
            
            while (roll != 6)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine($"You rolled a {roll}");
                attempts++;
            }

            Console.WriteLine($"It took you {attempts} attempts to roll a perfect six!");
        }
    }
}
