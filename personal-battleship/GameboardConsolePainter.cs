public class GameboardConsolePainter
{
    private Gameboard? Gameboard;
    const char OccupiedSpaceIcon = 'O';
    const char UnoccupiedSpaceIcon = '.';
    const char HorizontalLineChar = '-';
    const char VerticalLineChar = '|';
    const char CornerChar = '+';
    public void Print(Gameboard gameboard)
    {
        Console.SetCursorPosition(0, 0);
        Gameboard = gameboard;
        var gbtext = GameboardCharOutput();
        for (int y = 0; y < Gameboard.GameboardSize + 2; y++)
        {
            for(int x = 0; x < Gameboard.GameboardSize + 2; x++)
            {
                Console.Write(gbtext[y, x]);
            }
            Console.Write('\n');
        }
    }
    private char[,] GameboardCharOutput(int length = Gameboard.GameboardSize + 1)
    {
        char[,] gameboard = new char[length +1, length + 1];
        for (int y = 0; y < length; y++)
            for (int x = 0; x < length; x++)
            {
                gameboard[y, x] = UnoccupiedSpaceIcon;
            }

        // Top and bottom lines
        for (int i = 0; i < length; i++)
        {
            gameboard[0, i] = HorizontalLineChar;
            gameboard[length, i] = HorizontalLineChar;
        }

        var dimension = Gameboard.GetPosistions();

        for (int y = 0; y < Gameboard.GameboardSize; y++)
        {
            gameboard[y + 1 , 0] = VerticalLineChar;
            gameboard[y + 1, length] = VerticalLineChar;

            for (int x = 0; x < Gameboard.GameboardSize; x++)
            {
                if (dimension[y, x] == Gameboard.OccupiedSpace)
                {
                    gameboard[y + 1, x + 1] = OccupiedSpaceIcon;
                }
                else if (dimension[y, x] == Gameboard.UnoccupiedSpace)
                {
                    gameboard[y + 1, x + 1 ] = UnoccupiedSpaceIcon;
                }
            }
        }


        // Corners
        gameboard[0, 0] = CornerChar;
        gameboard[0, length] = CornerChar;
        gameboard[length, 0] = CornerChar;
        gameboard[length, length] = CornerChar;

        return gameboard;
    }

    private char[] HorizontalLine(int length = Gameboard.GameboardSize + 2, char cornerSeperator = CornerChar, char lineChar = HorizontalLineChar)
    {
        var line = new char[length]; 

        for (int y = 1; y < Gameboard.GameboardSize; y++)
        {
            line[y] = lineChar;
        }

        line[length - 1] = cornerSeperator;
        return line;
    }
}