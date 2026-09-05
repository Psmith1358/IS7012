using System;

class Program
{
    static void Main()
    {
        // Payton Smith

        int randomNumber = new Random().Next(1, 7); // Generates number between 1 and 6
        int winningNumber = 4;

        Console.WriteLine("Random Number: " + randomNumber);

        if (randomNumber == winningNumber)
        {
            Console.WriteLine("Winner!");
        }
        else
        {
            Console.WriteLine("Loser!");
        }
    }
}