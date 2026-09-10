function buscar(arr, tam, num) {
    for (let i = 0; i < tam; i++) {
        if (arr[i] == num) {
            return i;
        }
    }
    return -1;
}

let arr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69];
let num = 40;
let tam = arr.length;

let idx = buscar(arr, tam, num);
if (idx != -1) {
    console.log("El elemento se encuentra en la posicion: " + (idx + 1));
} else {
    console.log("No se encuentra el elemento.");
}