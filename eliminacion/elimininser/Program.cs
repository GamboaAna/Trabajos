using System;

class Program {
    static void Main() {
        int[] inputArr = {11, 21, 31, 41, 51, 61};
        int position = 3;

        Console.Write("Antes de la eliminacion, el array es: ");
        for (int j = 0; j < inputArr.Length; j++) {
            Console.Write(inputArr[j] + " ");
        }

        int[] nuevoArr = new int[inputArr.Length - 1];
        for (int j = 0, k = 0; j < inputArr.Length; j++) {
            if (j != position) {
                nuevoArr[k] = inputArr[j];
                k++;
            }
        }

        Console.Write("\nDespues de la eliminacion, el array es: ");
        for (int j = 0; j < nuevoArr.Length; j++) {
            Console.Write(nuevoArr[j] + " ");
        }
    }
}