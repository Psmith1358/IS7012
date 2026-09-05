using System;

class Program
{
    static void Main()
    {
        // Payton Smith

        int randomNumber = new Random().Next(1, 7); 
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