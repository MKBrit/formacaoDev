#include <iostream>
#include <locale>  
using namespace std;

bool funcao(int n) {
    if (n <= 0) {
        return false;
    }

    int soma = 0;
    for (int i = 1; i <= n / 2; i++) {
        if (n % i == 0) {
            soma += i;
        }
    }
    return soma == n;
}

int main() {
    setlocale(LC_ALL, "portuguese");

    int n;
    cout << "Digite um número inteiro para verificar se é perfeito: ";
    cin >> n;

    if (funcao(n)) {
        cout << n << " é um número perfeito." << endl;
    }
    else {
        cout << n << " não é um número perfeito." << endl;
    }

    int max;
    cout << "Até que número máximo você deseja descobrir os números perfeitos? ";
    cin >> max;

    cout << "Números perfeitos até " << max << ":" << endl;
    for (int i = 1; i <= max; i++) {
        if (funcao(i)) {
            cout << i << " ";
        }
    }
    cout << endl;

    return 0;
}
