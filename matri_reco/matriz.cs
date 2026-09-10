using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Los elementos del array por columnas son: ");
        for (int col = 0; col < 3; col++)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}