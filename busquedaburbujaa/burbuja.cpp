#include <iostream>
using namespace std;

void burbu(int a[], int s) {
    for (int j = 0; j < s; j++) {
        bool cambio = false;
        for (int i = 0; i < s - j - 1; i++) {
            if (a[i] > a[i + 1]) {
                int temp = a[i];
                a[i] = a[i + 1];
                a[i + 1] = temp;
                cambio = true;
            }
        }
        if (cambio == false) {
            break;
        }
    }
}

int main() {
    int a[] = {15, 16, 11, 13, 14};
    int s = sizeof(a) / sizeof(a[0]);

    cout << "Antes de ordenar los elementos del array son: " << endl;
    for (int i = 0; i < s; i++) {
        cout << a[i] << " ";
    }

    burbu(a, s);

    cout << "\nDespues de ordenar los elementos del array son: " << endl;
    for (int i = 0; i < s; i++) {
        cout << a[i] << " ";
    }

    return 0;
}