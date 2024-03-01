//Miguel Brito - tarefa 19/07 Renato Cpp
#include <iostream>
#include <string>
#include <locale>
using namespace std;

int a(int n) {
    for (int i = 1; i <= n; i++) {
        string pontos(n - i + 1, '.');
        string asteriscos(2 * i - 1, '*');
        if (i > 99)
        cout << i << pontos << asteriscos << endl;
        else if (i > 9 && i <100)
        cout << "0" << i << pontos << asteriscos << endl;
        else 
        cout << "00" << i << pontos << asteriscos << endl;
    }
    cout << "Boas festas!" << endl;
    return 0;
}
int main() {
    setlocale(LC_ALL, "portuguese");
    int N;
    cout << "Digite um número inteiro positivo: ";
    cin >> N;
    a(N);
    return 0;
}
