function buscar(arr, l, h, num) {
    while (l <= h) {
        let mid = Math.floor(l + (h - l) / 2);
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

let arr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69];
let num = 40;
let tam = arr.length;

let idx = buscar(arr, 0, tam - 1, num);
if (idx != -1) {
    console.log("El elemento se encuentra en la posicion: " + (idx + 1));
} else {
    console.log("El elemento no se encuentra");
}