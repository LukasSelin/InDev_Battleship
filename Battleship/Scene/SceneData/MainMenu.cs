using System;
using System.Collections.Generic;
using System.Text;
using menu;

namespace Battleship.Scene
{
    class MainMenu : IScene
    {
        private string MenuHeader = "Battleship!";
        private string[] MenuContent = new string[] { "Start new game", "Load Game", "Options", "Exit" };
        public int Print()
        {
            Menu menu = new Menu(MenuHeader, MenuContent);
            menu = menu.GetMenu();

            return menu.SelectedIndex();
        }
        
    }
}
