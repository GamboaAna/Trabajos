public class burbuja {

    public static void bubbleSorbr(int[] a) {
        int s = a.length;
        for (int i2 = 0; i2 < s; i2++) {
            boolean cambio = false;
            for (int i = 0; i < s - i2 - 1; i++) {
                if (a[i] > a[i + 1]) {
                    int temp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = temp;
                    cambio = true;
                }
            }
            if (cambio == false) {
                break;
            }
        }
    }

    public static void main(String[] args) {
        int[] a = {15, 16, 11, 13, 14};

        System.out.println("Antes de ordenar los elementos del array son: ");
        for (int i : a) {
            System.out.print(i + " ");
        }

        bubbleSort(a);

        System.out.println("\nDespues de ordenar los elementos del array son: ");
        for (int i = 0; i < a.length; i++) {
            System.out.printf("%d ", a[i]);
        }
    }
}