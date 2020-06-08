using System;
using System.Collections.Generic;
using System.IO;
using Battleship;

namespace Battleship.Scene
{
    
    class GameboardScene : IScene
    {
        /*        012345678910  
         *      0 ########### |#¤#|
         *      1 #    #    # |#¤#|
         *      2 #    #    # |#¤#|
         *      3 ########### |#¤#|
         *      4 #    #    # |##|
         *      5 #    #    # |##|
         *      6 11111###### #||#
         *      7 1 23 # \/ # #||#
         *      8 1 32 # /\ # #||#
         *      9 11111###### #||#
         *       
         */
        // Gameboard 7x7
        // Nothing for misses X for hit
        // Boxes 6x4
        private void PrintNet()
        {
            // TODO
            
            // Repeat:
                // Set position
                // Print net
                // New row

            for(int i = 0; i < GameboardProperties.GameCoord_MaxHeight; i++)
            {
                Console.SetCursorPosition(GameboardProperties.GameCoord_MaxWidth + 1, i);
                Console.WriteLine(GameboardProperties.NetFormat);
            }
        }
        private void PrintPlayer(Players player)
        {
            Console.SetCursorPosition(0, 0);
            var gameboard = player == 0 ? GameManager.PlayerOneGameboard : GameManager.PlayerTwoGameboard;
           
            PrintPlayerBoard(gameboard);
        }
        private void PrintOpponent(Players player)
        {
            // Where to place the 2nd gameboard


            Gameboard gameboard = player == 0 ? GameManager.PlayerOneShots : GameManager.PlayerTwoShots;

            PrintPlayerBoard(gameboard);
        }
        private void PrintPlayerBoard(Gameboard gameboard)
        {
            for (int i = 0; i < GameboardProperties.GameCoord_MaxHeight; i++)
            {
                if(!gameboard.properties.isPlayer)
                {
                    int secondGameboardOffset = GameboardProperties.GameCoord_MaxWidth + GameboardProperties.NetFormat.Length + 2;
                    Console.SetCursorPosition(secondGameboardOffset, i);
                }
                char[] row = gameboard.GetRow(i);
                Console.WriteLine(row);
            }
        }

        private void PrintGameboard()
        {
            // Print playing gameboard
            PrintPlayer((Players)0);

            // Net
            PrintNet();

            // Print opponent gameboard
            PrintOpponent((Players)0);
        }
        public int Print()
        {
            PrintGameboard();
            return 0;
        }
    }
}
