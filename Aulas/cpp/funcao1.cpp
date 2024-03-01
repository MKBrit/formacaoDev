#include <iostream>
using namespace std;

int valor(int a, int b) {
    a = 2;
    return a * b;
}

int referencia(int &a, int &b) {
    a = 2;
    return a * b;
}

int ponteiro(int *a, int *b) {
    *a = 2;
    return (*a) * (*b);
}

int main() {
    int a, b;
    
    cout << "Valor de a: ";
    cin >> a;
    
    cout << "Valor de b: ";
    cin >> b;
    
    int val = valor(a, b);
    int ref = referencia(a, b);
    int res = ponteiro(&a, &b);
    
    cout << "Valor " << val << endl;
    cout << "Ref " << ref << endl;
    cout << "Ponteiro " << res << endl;    
    cout << "Valor de a final " << a << endl;
    
    return 0;
}