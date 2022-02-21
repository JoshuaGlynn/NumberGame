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
            // sets winning number
            Random rand = new Random();
            winningNumber = rand.Next(1, 11);

            // sets no of tries
            TotalGuesses = 3;
        }

        public Result MakeGuess(int guess)
        {
            TotalGuesses--;

            if (guess == winningNumber)
                return Result.Win;

            if (guess > winningNumber && TotalGuesses > 0)
                return Result.Higher;

            if (guess < winningNumber && TotalGuesses > 0)
                return Result.Lower;

            return Result.Lose;
        }

    }
}
