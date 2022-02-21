using NumberGuessingGame.Classes;
using System;
using static NumberGuessingGame.Classes.NumberGuesser;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesser = new NumberGuesser();

            Console.WriteLine(guesser.WelcomeText);

            guesser.PlayerName = Console.ReadLine();

            Console.WriteLine("Hello " + guesser.PlayerName + " lets play");

            Console.WriteLine("You have " + guesser.TotalGuesses + " guesses left, choose your first number (between 1 and 10)");

            do
            {

                // need to alert user if string not a number

                var userInput = Console.ReadLine();

                var isNumber = int.TryParse(userInput, out int guess);

                if (isNumber == false)
                {
                    Console.WriteLine("That isnt a number, try again.");
                    continue;
                }

                var result = guesser.MakeGuess(guess);

                if (result == Result.Higher)
                {
                    Console.WriteLine("Your number is higher than the answer. You have " + guesser.TotalGuesses + " guesses left");
                    continue;
                }

                if (result == Result.Lower)
                {
                    Console.WriteLine("Your number is lower than the answer. You have " + guesser.TotalGuesses + " guesses left");
                    continue;
                }

                if (result == Result.Win)
                {
                    Console.WriteLine("You have won. congratulations");
                    break;
                }


                if (result == Result.Lose)
                {
                    Console.WriteLine("You have lost. :(");
                    break;
                }


            } while (true);

            Console.ReadKey();

        }
    }
}
