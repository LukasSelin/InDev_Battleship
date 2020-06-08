using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public static class GameManager
    {
        public static Gameboard PlayerOneGameboard { get; } = new Gameboard(true);
        public static Gameboard PlayerOneShots { get; } = new Gameboard(false);

        public static Gameboard PlayerTwoGameboard { get; } = new Gameboard(true);
        public static Gameboard PlayerTwoShots { get; } = new Gameboard(false);

    }
}
