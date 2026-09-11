using System;

class Program
{
    static void Main(string[] args)
    {
        int r = 3;
        int c = 3;
        int[] arre = new int[r * c];
        int[,] arre2 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int k = 0;

        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                k = x * r + y;
                arre[k] = arre2[x, y];
                k = k + 1;
            }
        }

        Console.WriteLine("Los elementos del array bidimensional son: ");
        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                Console.Write(arre2[x, y] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nLos elementos del array unidimensional son: ");
        for (int x = 0; x < r; x++)
        {
            for (int y = 0; y < c; y++)
            {
                Console.Write(arre[x * r + y] + " ");
            }
        }
        Console.WriteLine();
    }
}
