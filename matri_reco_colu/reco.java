import java.util.Arrays;

public class reco {
    public static void main(String[] args) {
        int r = 3;
        int c = 3;
        int[] arre = new int[r * c];
        int[][] arre2 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
    int k = 0;

        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                k = x * r + y;
                arre[k] = arre2[x][y];
                k = k + 1;
            }
        }

        System.out.println("Los elementos del array bidimensional son: ");
        for (int[] row : arre2) {
            for (int ele : row) {
                System.out.print(ele + " ");
            }
            System.out.println();
        }

        System.out.println("\nLos elementos del array unidimensional son: ");
        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                System.out.print(arre[x * r + y] + " ");
            }
        }
    }
}
