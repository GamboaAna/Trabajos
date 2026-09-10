public class matriz {
    public static void main(String[] args) {
        int[][] arr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        System.out.println("Los elementos del array por columnas son: ");
        for (int col = 0; col < 3; col++) {
            for (int row = 0; row < 3; row++) {
                System.out.print(arr[row][col] + " ");
            }
            System.out.println();
        }
    }
}
