using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    enum Players
    {
        PlayerOne,
        PlayerTwo
    }
    public enum GameboardChars
    {
        BoardChar = GameboardProperties.BoardChar,
        WhiteSpace = ' ',
        PointLeft = '\'',
        PointRight = '/'
    }
    public class Gameboard
    {
        // Ships
        // Ship position

        // GameboardDesign
        // Ship position -> Leta kolumn/rad
        public GameboardProperties properties = new GameboardProperties();
        private Gameboard()
        {
            Setup();
        }
        public Gameboard(bool isPlayer) : this()
        {
            properties.isPlayer = isPlayer;
        }
        private int[] GetIntRow(int rowIndex)
        {
            List<int> row = new List<int>();
            for (int i = 0; i <= GameboardProperties.PlayerBoardWidth; i++)
            {
                row.Add(properties.GameCoords[rowIndex, i]);
            }
            return row.ToArray();
        }

        public char[] GetRow(int rowIndex)
        {
            int[] rowIntArray = GetIntRow(rowIndex);
            char[] rowCharArray = new char[GameboardProperties.PlayerBoardWidth + 1];

            for (int i = 0; i < rowIntArray.Length; i++)
            {
                rowCharArray[i] = rowIntArray[i] == 1 ? GameboardProperties.BoardChar : (char)GameboardChars.WhiteSpace;
            }
            return rowCharArray;
        }
        public char[,] GetGameboard()
        {
            char[,] Gameboard = new char[GameboardProperties.GameCoord_MaxHeight, GameboardProperties.GameCoord_MaxWidth];

            for (int i = 0; i <= GameboardProperties.PlayerBoardHeight; i++)
            {
                var row = GetRow(i);
                for (int j = 0; j < GameboardProperties.PlayerBoardWidth; j++)
                {
                    Gameboard[i, j] = row[j];
                }
            }
            return Gameboard;
        }
        private void Setup()
        {
            // Rad
            for (int i = 0; i <= GameboardProperties.PlayerBoardHeight; i += 3)
            {
                for (int j = 0; j <= GameboardProperties.PlayerBoardWidth; j++)
                {
                    properties.GameCoords[i, j] = 1;
                }
            }

            // Kolumn
            for (int i = 0; i <= GameboardProperties.PlayerBoardWidth; i += 5)
            {
                for (int j = 0; j <= GameboardProperties.PlayerBoardHeight; j++)
                {
                    properties.GameCoords[j, i] = 1;
                }
            }
        }
    }
}
