using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_branching_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a game that can be played by two players.
            // At the start, players are asked to enter their nicknames.
            // The nicknames are stored until the end of the game.
            // The program selects a random number, "gameNumber," between 12 and 50, informing the players of this number.
            // Players take turns (the game informs about the current player's turn).
            // The player whose turn it is enters a number, "userTry," which can be 1, 2, 3, or 4.
            // The entered number is subtracted from "gameNumber."
            // The new value of "gameNumber" is displayed to the players on the screen.
            // The player who, after their turn, makes "gameNumber" equal to zero wins.
            // The game congratulates the winner and offers a rematch.
            // Demonstration
            // Number: 12
            // User1's Turn: 3
            //
            // Number: 9
            // User2's Turn: 4
            //
            // Number: 5
            // User1's Turn: 2
            //
            // Number: 3
            // User2's Turn: 3
            //
            // User2 Wins!

            string user1, user2;
            int choice;
            int gameNumber;
            Random randomize= new Random();
            Console.WriteLine("User 1, provide your nickname:");
            user1=Console.ReadLine();
            Console.WriteLine("User 1 name is " + user1+"\n User 2, provide your nickname: ");
            user2 =Console.ReadLine();
            Console.WriteLine("User 2 name is " + user2);
            gameNumber = randomize.Next(12,51);
            Console.WriteLine($"\nRandom number is {gameNumber}");
            
            for(int i = 0; gameNumber > 0; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{user1}:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 0 && choice < 5)
                    {
                        gameNumber = gameNumber - choice;
                    }
                    else
                    {
                        Console.WriteLine("Number should be 1, 2, 3 or 4, you skipping you'r turn");
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"GameNumber is {gameNumber}, congratulations to {user1}");
                    }
                    else if (gameNumber < 0)
                    {
                        Console.WriteLine($"Gamenumber is {gameNumber}, {user1} loosed");
                    }
                    else
                    {
                        Console.WriteLine($"GameNumber now is {gameNumber}");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{user2}:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice > 0 && choice < 5)
                    {
                        gameNumber = gameNumber - choice;
                    }
                    else
                    {
                        Console.WriteLine("Number should be 1, 2, 3 or 4, you skipping you'r turn");
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"GameNumber is {gameNumber}, congratulations to {user2}");
                    }
                    else if (gameNumber < 0)
                    {
                        Console.WriteLine($"Gamenumber is {gameNumber}, {user2} loosed");
                    }
                    else
                    {
                        Console.WriteLine($"GameNumber now is {gameNumber}");
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
