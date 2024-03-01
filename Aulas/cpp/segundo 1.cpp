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
    cout << "Digite um n�mero inteiro para verificar se � perfeito: ";
    cin >> n;

    if (funcao(n)) {
        cout << n << " � um n�mero perfeito." << endl;
    }
    else {
        cout << n << " n�o � um n�mero perfeito." << endl;
    }

    int max;
    cout << "At� que n�mero m�ximo voc� deseja descobrir os n�meros perfeitos? ";
    cin >> max;

    cout << "N�meros perfeitos at� " << max << ":" << endl;
    for (int i = 1; i <= max; i++) {
        if (funcao(i)) {
            cout << i << " ";
        }
    }
    cout << endl;

    return 0;
}
