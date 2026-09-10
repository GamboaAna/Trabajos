public class recinv {
    public static void main (String[] args) 
    { 
        int arr[] = {40, 50, 60, 70, 80, 90}; 
        int size = arr.length; 
        System.out.println("Recorrido lineal (secuencial): "); 
        System.out.print("Los elementos del array son: "); 
        for(int idx = size -1; idx >= 0; idx--) 
            { 
                System.out.print(arr[idx] + " "); 
            } 
    }
}