#include <iostream>
using namespace std;

int main() {
    int n;

    cout << "Introduza quantos nr's quer guardar: ";
    cin >> n;

    int *array = new int[n];

    for (int i = 0; i < n; i++) {
        cout << "Nr " << i + 1 << ": ";
        cin >> array[i];
    }

    cout << "Nr's guardados: ";
    for (int i = 0; i < n; i++) {
        cout << array[i] << " ";
    }
    cout << endl;

    delete[] array;

    return 0;
}