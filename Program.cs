using System;
using battleship;

namespace program
{
    class Program
    {   
        static void launchGame()
        {
            string menuHeader = "Select player:";
            string[] menuContent = {"Player 1", "Player 2", "Go back"};

            var menu = new Menu(menuContent);
            
            bool done = false;

            do{
                menu = menu.GetMenu(menu, menuHeader);
                switch(menu.SelectedIndex)
                {
                    case 0:
                        battleShipMechanics.addShip(1);
                        Console.WriteLine("Nu är player 1 klar");
                        Console.ReadKey();
                    break;

                    case 1:
                        battleShipMechanics.addShip(2);
                        Console.WriteLine("Nu är player 2 klar");
                        Console.ReadKey();
                    break;

                    case 2:
                        startNewGame();
                    break;
                }

            }while(!done);
       
                    Console.WriteLine("Tjennare tjenare ");


        }
        static void startNewGame()
        {
            string menuHeader = "Start new game";
            string[] menuContent = {"Launch game", "Settings", "Go back"};
            
            var menu = new Menu(menuContent);
            menu = menu.GetMenu(menu, menuHeader);

            switch(menu.SelectedIndex)
            {
                case 0:
                // Launch game
                    launchGame();
                    

                break;

                case 1:
                // Settings
                    throw new Exception("Not yet implemented");

                case 2:
                // Go back
                    launchGameMenu();
                break;

                default:
                // Wrong

                break;

            }
        }
        static void launchGameMenu()
        {
            string menuHeader = "Battleship";
            string[] menuContent = {"New game", "Load game", "Leaderboard", "Exit"};

            var menu = new Menu(menuContent);

            menu = menu.GetMenu(menu, menuHeader);

            switch(menu.SelectedIndex)
            {
                case 0:
                    // Nytt spel
                    startNewGame();
                break;

                case 1:
                    // Ladda spel

                break;

                case 2:
                    // Leaderboard

                break;

                case 3:
                    // Avsluta
                    Console.ResetColor();
                break;

                default:
                    // Fel hanterig

                break;
            }
        }
        static void Main(string[] args)
        {            
            launchGameMenu();
        }
    }
}
