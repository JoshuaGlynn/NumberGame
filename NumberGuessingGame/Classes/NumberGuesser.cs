using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Classes
{
    public class NumberGuesser
    {
        private int winningNumber;

        public int TotalGuesses { get; private set;  }

        public enum Result
        {
            Win,
            Higher,
            Lower,
            Lose
        }


        public string WelcomeText { get; } = "Hello, type your name to start";

        public string PlayerName { get; set; }

        public NumberGuesser()
        {
            // Creates a random object
            Random rand = new Random();

            // Calls Next() on rand to generate a number between 1 - 10
            winningNumber = rand.Next(1, 11);

            // sets no of tries
            TotalGuesses = 3;
        }

        public Result MakeGuess(int guess)
        {
            // When caller makes a guess reduce the TotalGuesses by 1

            TotalGuesses--;

            // return result
            if (guess == winningNumber)
                return Result.Win;

            if (guess > winningNumber && TotalGuesses > 0)
                return Result.Higher;

            if (guess < winningNumber && TotalGuesses > 0)
                return Result.Lower;

            // Returns lose if above conditions not met
            return Result.Lose;
        }

    }
}
