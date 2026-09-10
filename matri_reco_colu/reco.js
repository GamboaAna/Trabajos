let r = 3; 
let c = 3;
let arre = new Array(r * c).fill(0);
let arre2 = [ [1, 2, 3],
               [4, 5, 6],
               [7, 8, 9] ];
let k = 0;

for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        k = x * r + y;
        arre[k] = arre2[x][y];
        k = k + 1;
    }
}

console.log("Los elementos del array bidimensional son: ");
for (let row of arre2) {
    console.log(row.join(" "));
}

console.log("\nLos elementos del array unidimensional son: ");
let res = "";
for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        res += arre[x * r + y] + " ";
    }
}
console.log(res);