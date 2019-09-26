using System;
using battleship;


namespace gameboard
{
    class gameboardPainter
    {
        public static void printGameboard(int playerID)
        {
            // Printar ut själva gameboarden
            Console.Clear();
            gameboardPainter.printRow();             // T.ex +-----+
            gameboardPainter.printContent(playerID); // T.ex |~~~x~|
            gameboardPainter.printRow();             // T.ex +-----+
        }
        static void printRow()
        {
            Console.Write('+');

            for (int i = 0; i < battleshipSettings.gameboardLength; i++)
            {
                Console.Write('-');
            }
            Console.Write('+');

            Console.Write('\n');
        }
        static void printContent(int playerID)
        {
            for (int y = 0; y < battleshipSettings.gameboardCoordinats.GetLength(1); y++)
            {
                Console.Write('|');

                for (int x = 0; x < battleshipSettings.gameboardCoordinats.GetLength(0); x++)
                {
                    if (battleshipSettings.gameboardCoordinats[x, y] == 1)
                    {
                        Console.Write('x');

                    }
                    else if (battleshipSettings.playerOneShipCoordinats[x, y] == 1 && playerID == 1) 
                    { // Så player 1 ser sin gameboard men inte player 2 gameboard
                        Console.Write('x');

                    }
                    else if (battleshipSettings.playerTwoShipCoordinats[x, y] == 1 && playerID == 2)
                    { // Så player 2 ser sin gameboard men inte player 1 gameboard
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write('~');
                    }
                }
                Console.Write('|');
                Console.Write('\n');
            }
        }
    }
}