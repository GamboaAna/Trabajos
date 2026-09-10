#include <iostream>
using namespace std;

int main() {
    int inputArr[7] = {11, 21, 31, 41, 51, 61}; 
    int tam = 6; 
    int num = 52;

    cout << "Antes de la insercion, el array es: ";
    for (int i = 0; i < tam; i++) {
        cout << inputArr[i] << " ";
    }

    for (int i = tam; i > 0; i--) {
        inputArr[i] = inputArr[i - 1];
    }
    inputArr[0] = num;
    tam++;

    cout << "\nDespues de la insercion, el array es: ";
    for (int i = 0; i < tam; i++) {
        cout << inputArr[i] << " ";
    }

    return 0;
}