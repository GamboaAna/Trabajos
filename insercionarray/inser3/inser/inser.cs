using System;
using System.Collections.Generic;

List<int> inputArr = new List<int> { 11, 21, 31, 41, 51, 61 };
int num = 52;

Console.Write("Antes de la insercion, el array es: ");
for (int i = 0; i < inputArr.Count; i++)
{
    Console.Write(inputArr[i] + " ");
}

inputArr.Add(num);

Console.Write("\nDespues de la insercion, el array es: ");
for (int i = 0; i < inputArr.Count; i++)
{
    Console.Write(inputArr[i] + " ");
}