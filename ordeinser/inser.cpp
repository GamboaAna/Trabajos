#include <iostream>
using namespace std;

void inserr(int a[], int s) {
    for (int i= 0; i < s; i++) {
        int temp = a[i];
        int j = i - 1;
        while (j >= 0 && temp < a[j]){
            a[j + 1] = a[j];
            j = j - 1;
        }
        a[j + 1] = temp;

    }
}

void arra(int a[], int s) {
    for (int i = 0; i < s;i++){
        cout << a[i] << " ";
    }
}


int main() {
    int a[] = {15, 16, 11, 13, 14};
    int s = sizeof(a) / sizeof(a[0]); 

    cout << "Antes de la insercion: ";
    arra(a, s);
    inserr(a, s);

    cout << "\nDespues de la insercion: ";
    arra(a, s);
}