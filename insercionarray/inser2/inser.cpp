#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> inputArr = {11, 21, 31, 41, 51, 61};
    int num = 52;

    cout << "Antes de la insercion, el array es: ";
    for (int i = 0; i < inputArr.size(); i++) {
        cout << inputArr[i] << " ";
    }

    inputArr.insert(inputArr.begin() + 5, num);

    cout << "\nDespues de la insercion, el array es: ";
    for (int i = 0; i < inputArr.size(); i++) {
        cout << inputArr[i] << " ";
    }

    return 0;
}