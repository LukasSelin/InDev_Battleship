using System;
using System.Collections.Generic;
using System.Text;
using menu;

namespace Battleship.Scene
{
    class Options : IScene
    {
        private string MenuHeader = "Options";
        private string[] MenuContent = new string[] { "To be implemented", "To be implemented", "To be implemented", "Exit" };
        public int Print()
        {
            Menu menu = new Menu(MenuHeader, MenuContent);
            menu = menu.GetMenu();

            return menu.SelectedIndex();
        }
    }
}
