using System;

class Program
{
    static void Burbu(int[] a, int s)
    {
        for (int j = 0; j < s; j++)
        {
            bool cambio = false;
            for (int i = 0; i < s - j - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    cambio = true;
                }
            }
            if (cambio == false)
            {
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] a = { 15, 16, 11, 13, 14 };
        int s = a.Length;

        Console.WriteLine("Antes de ordenar los elementos del array son: ");
        for (int i = 0; i < s; i++)
        {
            Console.Write(a[i] + " ");
        }

        Burbu(a, s);

        Console.WriteLine("\nDespues de ordenar los elementos del array son: ");
        for (int i = 0; i < s; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}