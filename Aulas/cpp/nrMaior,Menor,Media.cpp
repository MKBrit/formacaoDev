#include <iostream>
using namespace std;

int main() {

	float counter, nr, maior, menor, soma, media;
	cout << "Introduza a quantidade de números a ler " << endl;
	cin >> counter;
	cout << "Introduza o 1º número " << endl;
	cin >> nr;
	maior = nr;
	menor = nr;
	soma = nr;
	for (int x = 2; x <= counter; x++){
		cout << "Introduza o " << x << "º número " << endl;
		cin >> nr;
		soma += nr;
		if (nr > maior){
			maior = nr;
		}
		else if (nr < menor) {
			menor = nr;
		}
	}
	media = soma / counter;

	cout << "O maior nr é o " << maior << "," << endl << "o menor é o " << menor << "," << endl << "e a média é de  " << media << "." << endl;
	
	return 0;
}