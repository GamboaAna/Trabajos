import java.util.ArrayList;

public class Insercion {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>();
        inputArr.add(11);
        inputArr.add(21);
        inputArr.add(31);
        inputArr.add(41);
        inputArr.add(51);
        inputArr.add(61);

        int num = 52;

        System.out.print("Antes de la insercion, el array es: ");
        for (int i = 0; i < inputArr.size(); i++) {
            System.out.print(inputArr.get(i) + " ");
        }

        inputArr.add(0, num);

        System.out.print("\nDespues de la insercion, el array es: ");
        for (int i = 0; i < inputArr.size(); i++) {
            System.out.print(inputArr.get(i) + " ");
        }
    }
}