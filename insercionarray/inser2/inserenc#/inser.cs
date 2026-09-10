using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> inputArr = new List<int> { 11, 21, 31, 41, 51, 61 };
        int num = 52;

        Console.Write("Antes de la insercion, el array es: ");
        for (int i = 0; i < inputArr.Count; i++)
        {
            Console.Write(inputArr[i] + " ");
        }

        inputArr.Insert(5, num);

        Console.Write("\nDespues de la insercion, el array es: ");
        for (int i = 0; i < inputArr.Count; i++)
        {
            Console.Write(inputArr[i] + " ");
        }
    }

    /*Perdi el comando de terminal para hacerlo dentro de las carpetas
    normalmente, por eso hay algunos fuera de carpetas y otros dentro jeje.*/
}