#include <iostream>
#include <ctime>
#include <stdlib.h>
#include <locale>
using namespace std;

int main() {
	setlocale(LC_ALL, "pt-pt");

	int aposta, tentativas = 0;
	srand(time(0));
	int theNumber = 1+rand() % 2;

	while (tentativas < 3) {
		tentativas++;
		cout << "Fa�a a sua aposta: " << endl;
		cin >> aposta;
		cout << endl;		
		if (aposta == theNumber) {
			cout << "Parab�ns!" << endl << "Levante o seu pr�mio!" << endl << "Nr de tentativas: " << tentativas << endl << endl;
			break;
		}
		else if (tentativas == 3) {
			cout << "Tenta novamente mais tarde" << endl;
			break;
		}
		else if (aposta > theNumber && tentativas != 3) 
			cout << "O seu nr � superior ao n�mero certo" << endl << endl;		
		else if (aposta < theNumber && tentativas != 3) 
			cout << "O seu nr � inferior ao n�mero certo" << endl << endl;		
	}
	return 0;
}