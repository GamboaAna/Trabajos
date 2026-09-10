import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class inser {
    public static void main(String[] args) {
        List<Integer> inputArr = new ArrayList<>(Arrays.asList(11, 21, 31, 41, 51, 61));
        int num = 52;

        System.out.print("Antes de la insercion, el array es: ");
        for (int i = 0; i < inputArr.size(); i++) {
            System.out.print(inputArr.get(i) + " ");
        }

        inputArr.add(num);

        System.out.print("\nDespues de la insercion, el array es: ");
        for (int i = 0; i < inputArr.size(); i++) {
            System.out.print(inputArr.get(i) + " ");
        }
    }
}