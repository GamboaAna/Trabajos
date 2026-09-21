let inputArr = [11, 21, 31, 41, 51, 61];
let position = 3;

console.log("Antes de la eliminacion, el array es: " + inputArr.join(" "));

inputArr.splice(position, 1);

console.log("Despues de la eliminacion, el array es: " + inputArr.join(" "));