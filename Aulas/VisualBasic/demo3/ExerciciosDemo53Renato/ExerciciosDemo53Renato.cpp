#include <iostream>
using namespace std;

int main() {

	float counter, nr, maior, menor, soma;
	float media;
	cout << "Introduza a quantidade de n�meros a ler " << endl;
	cin >> counter;
	cout << "Introduza o 1� n�mero " << endl;
	cin >> nr;
	maior = nr;
	menor = nr;
	soma = nr;
	for (int x = 2; x < counter; x++){
		cout << "Introduza o " << x << "� n�mero " << endl;
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

	cout << "O maior nr � o " << maior << "." << endl;
	cout << "O menor nr � o " << menor << "." << endl;
	cout << "A m�dia � de  " << media << "." << endl;

	

	
	return 0;
}