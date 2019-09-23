using System;

namespace battleship
{
    class Program
    {   
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
                    return;

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
