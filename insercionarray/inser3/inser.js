let inputArr = [11, 21, 31, 41, 51, 61];
let ele = 52;

let antes = "Antes de la insercion, el array es: ";
for (let i = 0; i < inputArr.length; i++) {
    antes += inputArr[i] + " ";
}
console.log(antes);

inputArr.push(ele);

let despues = "Despues de la insercion, el array es: ";
for (let i = 0; i < inputArr.length; i++) {
    despues += inputArr[i] + " ";
}
console.log(despues);