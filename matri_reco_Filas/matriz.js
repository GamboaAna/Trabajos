const arr = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

console.log("Los elementos del array por columnas son: ");
for (let col = 0; col < arr[0].length; col++) {
    let columna = "";
    for (let row = 0; row < arr.length; row++) {
        columna += arr[row][col] + " ";
    }
    console.log(columna);
}