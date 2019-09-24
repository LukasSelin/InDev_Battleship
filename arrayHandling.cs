using System;


namespace battleship
{
    class arrayHandling
    {
        public static void copy2DArrayContent(int[,] sourceArray, int[,] destinationArray)
        {
            for (int y = 0; y < sourceArray.GetLength(1); y++)
            {
                for (int x = 0; x < sourceArray.GetLength(0); x++)
                {
                    destinationArray[x,y] = sourceArray[x,y];
                }
            }
        }
    
        public static void write2DArray()
        {
            for (int y = 0; y < battleshipSettings.shipCoordinats.GetLength(1); y++)
            {
                for (int x = 0; x < battleshipSettings.shipCoordinats.GetLength(0); x++)
                {
                    Console.Write(battleshipSettings.shipCoordinats[x,y]);
                }
            }
        }
    
    
    }


}