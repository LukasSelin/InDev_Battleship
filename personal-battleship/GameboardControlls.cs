// See https://aka.ms/new-console-template for more information



public class GameboardControlls
{
    private Gameboard Gameboard;
    private GameboardConsolePainter GameboardConsolePainter;
    public GameboardControlls()
    {
        Gameboard = new Gameboard();
        GameboardConsolePainter = new GameboardConsolePainter();
    }
    (int Y, int X) CurrentPosition = (0, 0);

    public void Move()
    {
        while(true)
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch(consoleKeyInfo.Key)
            {
                case ConsoleKey.W:
                    MoveUp();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.UpArrow:
                    MoveUp();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.A:
                    MoveLeft();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.S:
                    MoveDown();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.DownArrow:
                    MoveDown();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.D:
                    MoveRight();
                    GameboardConsolePainter.Print(Gameboard);

                    break;
                
                case ConsoleKey.RightArrow:
                    MoveRight();
                    GameboardConsolePainter.Print(Gameboard);
                    break;

                case ConsoleKey.Enter:
                    Gameboard.OccupySpace(CurrentPosition);
                    break;
            }
        }
    }

    public void MoveUp()
    {
        //Gameboard.ReleaseSpace(CurrentPosition);
        CurrentPosition = (CurrentPosition.Y - 1, CurrentPosition.X);
        Gameboard.OccupySpace(CurrentPosition);
    }
    public void MoveDown()
    {
        //Gameboard.ReleaseSpace(CurrentPosition);
        CurrentPosition = (CurrentPosition.Y + 1, CurrentPosition.X);
        Gameboard.OccupySpace(CurrentPosition);
    }
    public void MoveLeft()
    {
        //Gameboard.ReleaseSpace(CurrentPosition);
        CurrentPosition = (CurrentPosition.Y, CurrentPosition.X - 1);
        Gameboard.OccupySpace(CurrentPosition);
    }
    public void MoveRight()
    {
        Gameboard.ReleaseSpace(CurrentPosition);
        CurrentPosition = (CurrentPosition.Y, CurrentPosition.X + 1);
        Gameboard.OccupySpace(CurrentPosition);
    }

}
