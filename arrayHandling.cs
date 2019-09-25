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
                    if (destinationArray[x,y] == 1){

                    }else{
                        destinationArray[x,y] = sourceArray[x,y];
                    }
                }
            }
        }
    
    }


}