using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // call Play()<-game.cs to display board
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game newGame = new Game(playerOne, playerTwo);
            
            Console.WriteLine(newGame.Play().Name);
        }
    }
}
