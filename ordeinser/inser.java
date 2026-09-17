public class inser {
    public static void inserr(int[] a) {
        for (int i = 0; i < a.length; i++) {
            int temp = a[i];
            int j = i - 1;
            while (j >= 0 && temp < a[j]){
                a[j+1] = a[j];
                j = j - 1;
            }
    
            a[j + 1] = temp;
        }
    }

    public static void arra(int[] a) {
        for (int i = 0; i < a.length; i++) {
            System.out.print(a[i] + " ");
        }
    }

    public static void main(String[] args) {
        int[] a = {15, 16, 11, 13, 14};

        System.out.println("Antes de ordenar los elementos del array son: ");
        arra(a);
        inserr(a);

        System.out.println("\nDespues de ordenar los elementos del array son: ");
        arra(a);
    }
}