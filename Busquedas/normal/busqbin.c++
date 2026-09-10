#include <iostream>
#include <vector>
using namespace std;

int buscar(vector<int> arr, int tam, int num) {
    for (int i = 0; i < tam; i++) {
        if (arr[i] == num) {
            return i;
        }
    }
    return -1;
}

int main() {
    vector<int> arr = {12, 34, 10, 6, 40, 89, 98, 57, 19, 69};
    int num = 40;
    int tam = arr.size();

    int idx = buscar(arr, tam, num);
    if (idx != -1) {
        cout << "El elemento se encuentra en la posicion: " << (idx + 1) << endl;
    } else {
        cout << "No se encuentra el elemento" << endl;
    }

    return 0;
}