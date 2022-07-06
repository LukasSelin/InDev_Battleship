// See https://aka.ms/new-console-template for more information




public class Gameboard
{
    public const int GameboardSize = 10;
    public const int UnoccupiedSpace = 0;
    public const int OccupiedSpace = 1;

    private int[,] GameboardPostions = new int[GameboardSize, GameboardSize];

    public Gameboard()
    {
        // Fill gameboard with open spaces
        for (int y = 0; y < GameboardSize; y++)
        {
            for (int x = 0; x < GameboardSize; x++)
            {
                GameboardPostions[y, x] = UnoccupiedSpace;
            }
        }
    }
    public int[,] GetPosistions()
    {
        return GameboardPostions;
    }
    public int[] GetDimension(Dimensions dimensions, int position)
    {
        switch (dimensions)
        {
            case Dimensions.y:
                return GetXDimension(position);

            case Dimensions.x: 
                return GetYDimension(position);
            default: throw new ArgumentException("Not recongnized dimension");
        }
    }
    public void OccupySpace((int Y,int X) newPositionOccupied)
    {
        GameboardPostions[newPositionOccupied.Y, newPositionOccupied.X] = OccupiedSpace;
    }
    public void ReleaseSpace((int Y, int X) relasePosition)
    {
        GameboardPostions[relasePosition.Y, relasePosition.X] = UnoccupiedSpace;
    }
    //public void OccupySpace(int[,] newPositionOccupied)
    //{
    //    if (newPositionOccupied == null) throw new ArgumentNullException(nameof(newPositionOccupied));
    //    if (newPositionOccupied.Rank != 2) throw new ArgumentException(nameof(newPositionOccupied) + " dimension is not an 2 dimensional array");

    //    for (int y = 0; y < GameboardSize; y++)
    //    {
    //        for (int x = 0; x < GameboardSize; x++)
    //        {
    //            if (newPositionOccupied[y, x] == OccupiedSpace)
    //            {
    //                GameboardPostions[y, x] = newPositionOccupied[y, x];
    //            }
    //        }
    //    }
    //}
    private int[] GetXDimension(int x)
    {
        int[] dimensions = new int[GameboardSize];
        for (int y = 0; y < Gameboard.GameboardSize; y++)
        {
            dimensions[y] = GameboardPostions[x, y];
        }
        return dimensions;
    }
    private int[] GetYDimension(int y)
    {
        int[] dimensions = new int[GameboardSize];
        for (int i = 0; i < Gameboard.GameboardSize; i++)
        {
            dimensions[i] = GameboardPostions[i, i];
        }
        return dimensions;
    }
}
