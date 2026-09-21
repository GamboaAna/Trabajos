#include <iostream>
using namespace std;

int main() {
    int inputArr[] = {11, 21, 31, 41, 51, 61};
    int n = sizeof(inputArr) / sizeof(inputArr[0]);
    int position = 3;

    cout << "Antes de la eliminacion, el array es: ";
    for (int j = 0; j < n; j++) {
        cout << inputArr[j] << " ";
    }

    for (int j = position; j < n - 1; j++) {
        inputArr[j] = inputArr[j + 1];
    }
    n--;

    cout << "\nDespues de la eliminacion, el array es: ";
    for (int j = 0; j < n; j++) {
        cout << inputArr[j] << " ";
    }

    return 0;
}