const dim3 = [
  [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
  ],
  [
    [10, 11, 12],
    [13, 14, 15],
    [16, 17, 18]
  ]
];

console.log("Los elementos del array son: ");
for (const dim2 of dim3) {
  for (const fila of dim2) {
    for (const element of fila) {
      process.stdout.write(element + " ");
    }
  }
  console.log();
}
