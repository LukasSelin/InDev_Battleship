using System;
using gameboard;

namespace battleship
{
    class battleshipSettings
    {
        /*
            Lenght:
            Carrier = 5  
            Battleship = 4
            Cruiser = 3
            Submarine = 3
            Destroyer = 2       
        
         */
        // Standard game settings
        public static int gameboardLength { get; set; } = 11;
        public static int gameboardHeight { get; set; } = 7;
        public static int startX = gameboardLength / 2;
        public static int startY = gameboardHeight / 2;
        public static int numberOfCarriers = 1;
        public static int numberOfBattleships = 1;
        public static int numberOfCruisers = 1;
        public static int numberOfSubmarines = 1;
        public static int numberOfDestroyers = 1;
        public static int[,] gameboardCoordinats { get; set; } = new int[gameboardLength, gameboardHeight];
        public static int[,] playerOneShipCoordinats { get; set; } = new int[gameboardLength, gameboardHeight];
        public static int[,] playerTwoShipCoordinats { get; set; } = new int[gameboardLength, gameboardHeight];


    }
    
    class battleShipMechanics
    {
        public static void addShip(int playerID)
        {
            // Destroyer = 2
            for (int i = 0; i < battleshipSettings.numberOfDestroyers; i++)
            {
                Move(2, playerID);
            }
            // Cruiser = 3
            for (int i = 0; i < battleshipSettings.numberOfCruisers; i++)
            {
                Move(3, playerID);
            }
            // Submarine = 3
            for (int i = 0; i < battleshipSettings.numberOfSubmarines; i++)
            {
                Move(3, playerID);
            }
            // Battleship = 4
            for (int i = 0; i < battleshipSettings.numberOfBattleships; i++)
            {
                Move(4, playerID);
            }
            // Carrier = 5  
            for (int i = 0; i < battleshipSettings.numberOfCarriers; i++)
            {
                Move(5, playerID);
            }
        }
        public static void Move(int lenght, int playerID)
        {
            bool done = false;
            do
            {
                gameboardPainter.printGameboard(playerID);
                var keyInfo = Console.ReadKey();
                try
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                            if (isInside())
                            {
                                battleshipSettings.startY = battleshipSettings.startY - 1;
                            }
                            for (int i = 0; i < lenght; i++)
                            {
                                if (isInside(i))
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY + i] = 1;
                                }
                                else
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY - i] = 1;
                                }
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                            if (isInside())
                            {
                                battleshipSettings.startY = battleshipSettings.startY + 1;
                            }
                            for (int i = 0; i < lenght; i++)
                            {
                                if (isInside(i))
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY - i] = 1;
                                }
                                else
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY + i] = 1;
                                }

                            }
                            break;

                        case ConsoleKey.RightArrow:
                            Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                            if (isInside())
                            {
                                battleshipSettings.startX = battleshipSettings.startX + 1;
                            }

                            for (int i = 0; i < lenght; i++)
                            {
                                if (isInside(i))
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX - i, battleshipSettings.startY] = 1;
                                }
                                else
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX + i, battleshipSettings.startY] = 1;
                                }
                            }
                            break;

                        case ConsoleKey.LeftArrow:
                            Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                            if (isInside())
                            {
                                battleshipSettings.startX = battleshipSettings.startX - 1;
                            }


                            for (int i = 0; i < lenght; i++)
                            {
                                if (isInside(i))
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX + i, battleshipSettings.startY] = 1;
                                }
                                else
                                {
                                    battleshipSettings.gameboardCoordinats[battleshipSettings.startX - i, battleshipSettings.startY] = 1;
                                }
                            }
                            break;

                        case ConsoleKey.Enter:
                            if (playerID == 1)
                            {
                                arrayHandling.copy2DArrayContent(battleshipSettings.gameboardCoordinats, battleshipSettings.playerOneShipCoordinats);
                            }
                            else
                            {
                                arrayHandling.copy2DArrayContent(battleshipSettings.gameboardCoordinats, battleshipSettings.playerTwoShipCoordinats);
                            }
                            battleshipSettings.startX = battleshipSettings.gameboardLength / 2;
                            battleshipSettings.startY = battleshipSettings.gameboardHeight / 2;
                            Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);


                            return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }
            } while (!done);

        }

        static void moveCoursor(int playerID, int x, int y)
        {
                gameboardPainter.printGameboard(playerID);
                var keyInfo = Console.ReadKey();

                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:

                    break;

                    case ConsoleKey.DownArrow:
                    break;

                    case ConsoleKey.RightArrow:
                    break;

                    case ConsoleKey.LeftArrow:
                    break;


                }
        }
        static bool isInside()
        {
            if (0 < battleshipSettings.startX && battleshipSettings.startX < battleshipSettings.gameboardLength - 1 && 0 < battleshipSettings.startY && battleshipSettings.startY < battleshipSettings.gameboardHeight - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool isInside(int offset)
        {
            if (0 < battleshipSettings.startX + offset && battleshipSettings.startX < (battleshipSettings.gameboardLength + offset - 1) && 0 < battleshipSettings.startY + offset && battleshipSettings.startY < (battleshipSettings.gameboardHeight + offset - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}