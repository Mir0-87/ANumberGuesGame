namespace GuessANumber
{
    using System;
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int computerNumber = randomNum.Next(1, 100);

            while (true)
            {
                Console.Write("Guess a number (1-100): ");
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);
                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}