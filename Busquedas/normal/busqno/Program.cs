using System;
using System.Collections.Generic;

class Program
{
    static int Buscar(List<int> arr, int tam, int num)
    {
        for (int i = 0; i < tam; i++)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        List<int> arr = new List<int> { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69 };
        int num = 40;
        int tam = arr.Count;

        int idx = Buscar(arr, tam, num);
        if (idx != -1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion: " + (idx + 1));
        }
        else
        {
            Console.WriteLine("No se encuentra el elemento.");
        }
    }
}