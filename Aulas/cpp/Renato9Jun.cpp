
#include <iostream>
#include <locale>
#include <string>
using namespace std;

int main() {
	setlocale(LC_ALL, "pt_PT");

	/*Exerc�cio
	Crie um programa em C++ para ler um n�mero inteiro x e calcular e imprimir o valor de y de acordo com as condi��es abaixo :
		� y = x, se x < 1;
		� y = 0, se x = 1;
		� y = x ^ 2, se x > 1;*/

	/*while (true) // test tool
	{	
		int x, y;
		cout << "\nIntroduza um nr inteiro " << endl;
		cin >> x;
		if (x < 1) y = x;	else if (x==1) y = 0;	else y = x * x;
		cout << "O valor � " << y << endl;
	}*/

	/*Escreva um programa que leia dois n�meros e que pergunte qual opera��o deseja realizar e apresente o resultado.

		Opera��es poss�veis : soma(+), subtra��o(-), multiplica��o(*) e divis�o(/ ).

		Exemplo :
		Introduza o n�mero1 : 10
		Introduza o n�mero2 : 5
		Qual a opera��o(+, -, *ou / ) : /

		Resultado : 2*/

	while (true)
	{	
		float nr1, nr2, output;
		string op;
		cout << "\nIntroduza 1� nr " << endl;
		cin >> nr1;
		cout << "Introduza 2� nr " << endl;
		cin >> nr2;
		cout << "Introduza a opera��o (+,-,*,/) " << endl;
		cin >> op;
		if (op == "+") {
			output = nr1 + nr2;
			cout << nr1 << "+" << nr2 << "=" << output << endl;
		}
		else if (op == "-") {
			output = nr1 - nr2;
			cout << nr1 << "-" << nr2 << "=" << output << endl;
		}
		else if (op == "*") {
			output = nr1 * nr2;
			cout << nr1 << "*" << nr2 << "=" << output << endl;
		}
		else
		{	output = nr1 / nr2;
			cout << nr1 << "/" << nr2 << "=" << output << endl;
		}
	}
}