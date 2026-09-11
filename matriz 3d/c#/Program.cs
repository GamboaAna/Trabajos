using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] dim3 = {
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            },
            {
                {10, 11, 12},
                {13, 14, 15},
                {16, 17, 18}
            }
        };

        Console.WriteLine("Los elementos del array son: ");
        for (int i = 0; i < dim3.GetLength(0); i++)
        {
            for (int j = 0; j < dim3.GetLength(1); j++)
            {
                for (int k = 0; k < dim3.GetLength(2); k++)
                {
                    Console.Write(dim3[i, j, k] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
