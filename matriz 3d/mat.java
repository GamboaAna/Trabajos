public class mat {
    public static void main(String[] args) {
        int[][][] dim3 = {
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            },
            {
                {10, 11, 12},
                {13, 14, 15},
                {16, 17, 18}
            }
        };

        System.out.println("Los elementos del array son: ");
        for (int[][] dim2 : dim3) {
            for (int[] fila : dim2) {
                for (int element : fila) {
                    System.out.print(element + " ");
                }
            }
            System.out.println();
        }
    }
}
