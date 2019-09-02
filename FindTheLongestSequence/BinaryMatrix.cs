using System;

namespace FindTheLongestSequence
{
    public static class BinaryMatrix 
    {
        public static int FindSequence(int[,] matrix)
        {
            
            int counterRow = 0;
            int counterColumn = 0;
            int maxSequence = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        counterRow++;
                        counterColumn++;
                        for (int k = i + 1; k < matrix.GetLength(0); k++)
                        {
                            if (matrix[k, j] == 1)
                                counterColumn++;
                            else
                                break;
                        }
                        if (counterColumn > maxSequence)
                            maxSequence = counterColumn;
                        counterColumn = 0;
                    }
                    else
                    {
                        if (counterRow > maxSequence)
                            maxSequence = counterRow;
                        counterRow = 0;
                    }
                }
                if (counterRow > maxSequence)
                    maxSequence = counterRow;
                counterRow = 0;
            }
            return maxSequence;
        }

        public static int[,] CreateMatrix(int row, int column)
        {
            Random rnd = new Random();
            int[,] binaryMatrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    binaryMatrix[i, j] = rnd.Next(2);
                }
            }
            return binaryMatrix;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0} ", matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
