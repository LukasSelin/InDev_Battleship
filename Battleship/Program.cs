using System;
using Battleship.Scene;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            SceneController scene = new SceneController();
            scene.PrintScene((SceneEnum)3);

            //Console.Read();

            //Gameboard gameboard = new Gameboard();
            //var hej = gameboard.GetGameboard();


     
            Console.ReadKey();
            Console.WriteLine("Finished");

            

        }
    }
}

// Main Menu
// New Game - Load Game - Options
// Gameboard
// Paus
// Player 1/2 Wins

// *New Game*
// - Gameboard

// *Load Game*
// - Select Load
// - Gameboard

// *Options*
// - ***
// - ***
// - ***

// *Player 1/2*
// - Stats from the match
// - ?Leaderboard

// *Paus*
// - Letters on battleboard with paus

// *Gameboard*
// - In design
