import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class busqno {
    public static int buscar(List<Integer> arr, int tam, int num) {
        for (int i = 0; i < tam; i++) {
            if (arr.get(i) == num) {
                return i;
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        List<Integer> arr = new ArrayList<>(Arrays.asList(12, 34, 10, 6, 40, 89, 98, 57, 19, 69));
        int num = 40;
        int tam = arr.size();

        int idx = buscar(arr, tam, num);
        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posicion: " + (idx + 1));
        } else {
            System.out.println("No se encuentra el elemento.");
        }
    }
}