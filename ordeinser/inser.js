function insercion(a) {
    for (let i = 1; i < a.length; i++) {
        let temp = a[i];
        let j = i - 1;
        while (j >= 0 && temp < a[j]) {
            a[j + 1] = a[j];
            j = j - 1;
        }
        a[j + 1] = temp;
    }
}

function pinarra(a) {
    for (let i = 0; i < a.length; i++) {
        process.stdout.write(a[i] + " ");
    }
}

let a = [15, 16, 11, 13, 14];
console.log("Antes de ordenar los elementos del array son: ");
pinarra(a);
insercion(a);

console.log("\nDespues de ordenar los elementos del array son: ");
pinarra(a);