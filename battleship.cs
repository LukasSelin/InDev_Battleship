using System;

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
        public static int gameboardLength{get; set;} = 11;
        public static int gameboardHeight{get; set;} = 7;
        public static int startX = 0;
        public static int startY = 0;
        public static int numberOfCarriers = 1;
        public static int numberOfBattleships = 1;
        public static int numberOfCruisers = 1;
        public static int numberOfSubmarines = 1;
        public static int numberOfDestroyers = 1;

        public static int[,] gameboardCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];
        public static int[,] playerOneShipCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];
        public static int[,] playerTwoShipCoordinats{get; set;} = new int[gameboardLength, gameboardHeight];

        
    }
    class gameboardPainter
    {
        public static void printGameboard(int playerID)
        {
            Console.Clear();
            gameboardPainter.printRow();
            gameboardPainter.printContent(playerID);
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

        static void printContent(int playerID)
        {
            for (int y = 0; y < battleshipSettings.gameboardCoordinats.GetLength(1); y++)
            {
                Console.Write('|');

                for (int x = 0; x < battleshipSettings.gameboardCoordinats.GetLength(0); x++)
                {
                   if  (battleshipSettings.gameboardCoordinats[x, y] == 1)
                   {
                        Console.Write('x');
                      
                   }else if(battleshipSettings.playerOneShipCoordinats[x,y] == 1 && playerID == 1)
                   {
                        Console.Write('x');
                       
                   }else if(battleshipSettings.playerTwoShipCoordinats[x,y] == 1 && playerID == 2)
                   {
                        Console.Write('x');
                   }else
                   {
                       Console.Write('~');

                   }
                }
                Console.Write('|');
                Console.Write('\n');    
            }
        }
    }
    class battleShipMechanics
    {
        public static void addShip(int playerID)
        {                 
            // Destroyer = 2
            for (int i = 0; i < battleshipSettings.numberOfDestroyers; i++){
                Move(2, playerID);              
            }
            // Cruiser = 3
            for (int i = 0; i < battleshipSettings.numberOfCruisers; i++){
                Move(3, playerID);      
            }
            // Submarine = 3
            for (int i = 0; i < battleshipSettings.numberOfSubmarines; i++){
                Move(3, playerID);    
            }
            // Battleship = 4
            for (int i = 0; i < battleshipSettings.numberOfBattleships; i++){
                Move(4, playerID);       
            }
            // Carrier = 5  
            for (int i = 0; i < battleshipSettings.numberOfCarriers; i++){
                Move(5, playerID);               
            }
        }
        public static void Move(int lenght, int playerID)
        {         
            bool done = false;
            do{
                gameboardPainter.printGameboard(playerID);
                var keyInfo = Console.ReadKey();
                
                switch(keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                        if (battleshipSettings.startY != 0){
                            battleshipSettings.startY = battleshipSettings.startY - 1;
                        }

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY + i] = 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                        if (battleshipSettings.startY + 1 != battleshipSettings.gameboardHeight){
                            battleshipSettings.startY = battleshipSettings.startY + 1; 
                        } 

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.gameboardCoordinats[battleshipSettings.startX, battleshipSettings.startY - i] = 1;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                        if (battleshipSettings.startX +1 != battleshipSettings.gameboardLength){
                            battleshipSettings.startX = battleshipSettings.startX + 1;
                        }
                        
                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.gameboardCoordinats[battleshipSettings.startX - i, battleshipSettings.startY] = 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);

                        if (battleshipSettings.startX != 0){
                            battleshipSettings.startX = battleshipSettings.startX - 1;
                        }

                        for(int i = 0; i < lenght; i++){
                            battleshipSettings.gameboardCoordinats[battleshipSettings.startX + i, battleshipSettings.startY] = 1;
                        }
                        break;

                    case ConsoleKey.Enter:
                        if (playerID == 1){
                            arrayHandling.copy2DArrayContent(battleshipSettings.gameboardCoordinats, battleshipSettings.playerOneShipCoordinats);          
                        }else{
                            arrayHandling.copy2DArrayContent(battleshipSettings.gameboardCoordinats, battleshipSettings.playerTwoShipCoordinats);          
                        }
                        battleshipSettings.startX = battleshipSettings.gameboardLength/2;
                        battleshipSettings.startY = battleshipSettings.gameboardHeight/2;
                        Array.Clear(battleshipSettings.gameboardCoordinats, 0, battleshipSettings.gameboardCoordinats.Length);


                        return;                
                }
            }while(!done);

        }
    }
}