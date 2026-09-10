#include <iostream>

using namespace std; 

int main() {
    int numeros[] = {1, 2, 3, 4, 5, 6};
    int tamano = sizeof(numeros) / sizeof(numeros[0]);

    for (int i = 0; i < tamano; i++) 
    {
        cout << numeros[i] << " ";
    }
    cout << endl;

    return 0;
}


