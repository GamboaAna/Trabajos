using System;
using System.Collections.Generic;

class Program
{
    static int buscar(List<int> arr, int l, int h, int num)
    {
        while (l <= h)
        {
            int mid = l + (h - l) / 2;
            if (arr[mid] == num)
            {
                return mid;
            }
            else if (arr[mid] < num)
            {
                l = mid + 1;
            }
            else
            {
                h = mid - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        List<int> arr = new List<int> { 12, 34, 10, 6, 40, 89, 98, 57, 19, 69 };
        int num = 40;
        int tam = arr.Count;

        int idx = buscar(arr, 0, tam - 1, num);
        if (idx != -1)
        {
            Console.WriteLine("El elemento se encuentra en la posicion: " + (idx + 1));
        }
        else
        {
            Console.WriteLine("El elemento no se encuentra.");
        }
    }
}