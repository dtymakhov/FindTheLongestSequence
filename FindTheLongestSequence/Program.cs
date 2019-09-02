using System;

namespace FindTheLongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of rows: ");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of colums: ");
                int column = int.Parse(Console.ReadLine());
                int[,] matrix = BinaryMatrix.CreateMatrix(row, column);
                Console.WriteLine("Your matrix: ");
                BinaryMatrix.DisplayMatrix(matrix);
                Console.WriteLine($"The longest sequence of 1's: {BinaryMatrix.FindSequence(matrix)}");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please, enter only number");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
