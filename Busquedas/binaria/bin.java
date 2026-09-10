public class bin {
    public static int buscar(int[] arr, int l, int h, int num) {
        while (l <= h) {
            int mid = l + (h - l) / 2;
            if (arr[mid] == num) {
                return mid;
            } else if (arr[mid] < num) {
                l = mid + 1;
            } else {
                h = mid - 1;
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        int[] arr = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
        int num = 40;
        int tam = arr.length;

        int idx = buscar(arr, 0, tam - 1, num);
        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posicion: " + (idx + 1));
        } else {
            System.out.println("El elemento no se encuentra");
        }
    }
}