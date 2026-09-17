using System;

class Program
{
    static void inser(int[] a, int s)
    {
        for (int i = 0; i < s; i++)
        {
            int temp = a[i];
            int j = i - 1;
            while(j >= 0 && temp < a[j])
            {
                a[j + 1] = a[j];
                j = j - 1;
            }
            a[j + 1] = temp;
        }
    }

    static void arra(int[] a, int s)
    {
        for (int i = 0; i < s;i++){
        Console.Write(a[i] + " ");
        }
    }
    static void Main(string[] args)
    {
    int[] a = { 15, 16, 11, 13, 14 };
    int s = a.Length; 

     Console.WriteLine("Antes de la insercion: ");
    arra(a, s);
    inser(a, s);

    Console.WriteLine("\nDespues de la insercion: ");
    arra(a, s);
    }
}
