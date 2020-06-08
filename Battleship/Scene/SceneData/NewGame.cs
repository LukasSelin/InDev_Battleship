using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship.Scene
{
    class NewGame : IScene
    {
        private void PrintBanner()
        {
            Console.WriteLine(FiggleFonts.Standard.Render("New Game"));
        }

        public int Print()
        {
            PrintBanner();
            return 0;
        }
    }
}
