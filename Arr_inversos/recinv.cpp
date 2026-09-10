#include <iostream>

using namespace std; 

int main() {
    int numeros[] = {1, 2, 3, 4, 5, 6};
    int tamano = sizeof(numeros) / sizeof(numeros[0]);

    for (int i = tamano - 1; i >= 0; i--) 
    {
        cout << numeros[i] << " ";
    }
    cout << endl;

    return 0;
}
