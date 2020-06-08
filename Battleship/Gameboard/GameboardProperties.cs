using System;
using System.Collections.Generic;
using System.Text;

namespace Battleship
{
    public class GameboardProperties
    {
        // Static
        public const char BoardChar = '+';
        public static readonly string NetFormat = "|#¤#|";
        
        public static readonly int PlayerBoardHeight = 21;
        public static readonly int GameCoord_MaxHeight = PlayerBoardHeight + 1;
        
        public static readonly int PlayerBoardWidth = 35;
        public static readonly int GameCoord_MaxWidth = PlayerBoardWidth + 1;
        // END Static
        
        public bool isPlayer { get; internal set; }
        public int[,] GameCoords = new int[GameCoord_MaxHeight, GameCoord_MaxWidth];
    }
}
