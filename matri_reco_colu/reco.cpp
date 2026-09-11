#include <iostream>

using namespace std;

int main() {
    int r = 3;
    int c = 3;
    int arre[r * c];
    int arre2[3][3] = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };
    int k = 0;

    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            k = x * r + y;
            arre[k] = arre2[x][y];
            k = k + 1;
        }
    }

    cout << "Los elementos del array bidimensional son: " << endl;
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            cout << arre2[x][y] << " ";
        }
        cout << endl;
    }

    cout << "\nLos elementos del array unidimensional son: " << endl;
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            cout << arre[x * r + y] << " ";
        }
    }
    cout << endl;

    return 0;
}
