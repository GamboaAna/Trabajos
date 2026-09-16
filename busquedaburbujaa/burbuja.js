function bubbleSort(a) {
    let s = a.length;
    for (let i = 0; i < s; i++) {
        let cambio = false;
        for (let i = 0; i < s - i - 1; i++) {
            if (a[i] > a[i + 1]) {
                [a[i], a[i + 1]] = [a[i + 1], a[i]];
                cambio = true;
            }
        }
        if (cambio === false) {
            break;
        }
    }
}

let a = [15, 16, 11, 13, 14];
console.log("Antes de ordenar los elementos del array son: ");
for (let i of a) {
    process.stdout.write(i + ' ');
}

bubbleSort(a);
console.log("\nDespues de ordenar los elementos del array son: ");
for (let i = 0; i < a.length; i++) {
    process.stdout.write(a[i] + " ");
}