#include <iostream>
#include <locale>
using namespace std;

int main() {
	setlocale(LC_ALL, "pt-pt");
	int pin = 8888;
	int puk = 123456789;
	int pinInput, pukInput, tentativas = 3;
	cout << "Introduza o PIN " << endl;
	cin >> pinInput;
	if (pinInput == pin) {
		cout << "NOKIA" << endl << "Connecting Lives" << endl;
	}
	else if (pin != pinInput){
		while (tentativas > 1) {
			tentativas--;
			cout << "Tentativas restantes " << tentativas << endl << "Tente novamente " << endl;
			cin >> pinInput;
			if (pinInput == pin) {
				cout << "NOKIA" << endl << "Connecting Lives" << endl;
			}
			else if (pinInput != pin && tentativas == 1) {
				cout << "Introduza o PUK" << endl;
				cin >> pukInput;
				if (puk == pukInput) {
					cout << "NOKIA" << endl << "Connecting Lives" << endl;
				}
				else
					cout << "Telem�vel bloqueado";
					break;
			}
		}
	}
	return 0;
}



