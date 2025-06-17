
using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine("Guess a number between 1 and 100:");

        while (guess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < numberToGuess)
                Console.WriteLine("Too low!");
            else if (guess > numberToGuess)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct! You win!");
        }
    }
}
