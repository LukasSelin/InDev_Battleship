using System;

namespace battleship
{
    class battleshipSettings
    {
        // Standard game settings
        public static int gameboardLength{get; set;} = 11;
        public static int gameboardHeight{get; set;} = 6;
        public static int[,] gameboardCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];

    }
    class gameboardPainter
    {
        public static void printRow(){
            for (int i = 0; i < battleshipSettings.gameboardLength; i++)
            {
                Console.Write('-');
            }
        }

        public static void printContent()
        {
            
            
            for (int y = 0; y < battleshipSettings.gameboardCoordinats.GetLength(1); y++)
            {
                Console.Write('|');

                for (int x = 0; x < battleshipSettings.gameboardCoordinats.GetLength(0); x++)
                {
                    
                    Console.Write(battleshipSettings.gameboardCoordinats[x, y]);

                }
                Console.Write('|');

                Console.Write('\n');    
            }
        }
    }
}