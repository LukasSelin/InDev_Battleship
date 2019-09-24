using System;

namespace battleship
{
    class battleshipSettings
    {
        // Standard game settings
        public static int gameboardLength{get; set;} = 11;
        public static int gameboardHeight{get; set;} = 6;

        public static int startX = 0;
        public static int startY = 0;

        public static int[,] gameboardCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];
        public static int[,] shipCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];



        public static void Move(int lenght)
        {
         
            bool done = false;

            do{
                gameboardPainter.printGameboard();
                var keyInfo = Console.ReadKey();
                
                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                    Array.Clear(gameboardCoordinats, 0, gameboardCoordinats.Length);

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.startY = battleshipSettings.startY - 1;
                            gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY] = 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                    Array.Clear(gameboardCoordinats, 0, gameboardCoordinats.Length);


                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.startY = battleshipSettings.startY + 1;
                            gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY] = 1;

                        }
                        break;

                    case ConsoleKey.RightArrow:
                    Array.Clear(gameboardCoordinats, 0, gameboardCoordinats.Length);

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.startX = battleshipSettings.startX + 1;
                            gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY] = 1;

                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    Array.Clear(gameboardCoordinats, 0, gameboardCoordinats.Length);

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.startX = battleshipSettings.startX - 1;
                            gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY] = 1;
                        }

                        break;

                    case ConsoleKey.Enter:
                        arrayHandling.copy2DArrayContent(battleshipSettings.gameboardCoordinats, battleshipSettings.shipCoordinats);          

                        return;

                }

            }while(!done);

        }

        /*
            Lenght:
            Carrier = 5  
            Battleship = 4
            Cruiser = 3
            Submarine = 3
            Destroyer = 2       
        
         */

    }
    class gameboardPainter
    {
        public static void GetGameboard()
        {

        }
        public static void printGameboard()
        {
            Console.Clear();
            gameboardPainter.printRow();
            gameboardPainter.printContent();
            gameboardPainter.printRow();
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

        static void printContent()
        {
            for (int y = 0; y < battleshipSettings.gameboardCoordinats.GetLength(1); y++)
            {
                Console.Write('|');

                for (int x = 0; x < battleshipSettings.gameboardCoordinats.GetLength(0); x++)
                {
                   if  (battleshipSettings.gameboardCoordinats[x, y] == 1 || battleshipSettings.shipCoordinats[x,y] == 1)
                   {
                       Console.Write('x');
                   }else{
                       Console.Write('~');
                   }
                }
                Console.Write('|');
                Console.Write('\n');    
            }
        }
    }
    class gameboardMechanics
    {
        public static void addShip(int typeOfShip)
        {
            switch(typeOfShip)
            {
                case 2:
                // Destroyer = 2
                    battleshipSettings.Move(2);       
                break;

                case 3:
                // Cruiser = 3
                    battleshipSettings.Move(3);       

                break;
                case 6:
                // Submarine = 3
                    battleshipSettings.Move(3);       
                    
                break;

                case 4:
                // Battleship = 4
                    battleshipSettings.Move(4);       
                    
                break;

                case 5:
                // Carrier = 5  
                    battleshipSettings.Move(5);       
                    
                break;



            }
        }
    }
}