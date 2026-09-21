import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        int[] inputArr = {11, 21, 31, 41, 51, 61};

        System.out.print("Antes de la eliminacion, el array es: ");
        for (int j = 0; j < inputArr.length; j++) {
            System.out.print(inputArr[j] + " ");
        }

        int[] nuevoArr = new int[inputArr.length - 1];
        for (int j = 1; j < inputArr.length; j++) {
            nuevoArr[j - 1] = inputArr[j];
        }

        System.out.print("\nDespues de la eliminacion, el array es: ");
        for (int j = 0; j < nuevoArr.length; j++) {
            System.out.print(nuevoArr[j] + " ");
        }
    }
}