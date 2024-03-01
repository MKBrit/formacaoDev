
#include <iostream>
#include <locale>
#include <string>
using namespace std;

int main() {
	setlocale(LC_ALL, "pt_PT");

	/*Exercício
	Crie um programa em C++ para ler um número inteiro x e calcular e imprimir o valor de y de acordo com as condições abaixo :
		• y = x, se x < 1;
		• y = 0, se x = 1;
		• y = x ^ 2, se x > 1;*/

	/*while (true) // test tool
	{	
		int x, y;
		cout << "\nIntroduza um nr inteiro " << endl;
		cin >> x;
		if (x < 1) y = x;	else if (x==1) y = 0;	else y = x * x;
		cout << "O valor é " << y << endl;
	}*/

	/*Escreva um programa que leia dois números e que pergunte qual operação deseja realizar e apresente o resultado.

		Operações possíveis : soma(+), subtração(-), multiplicação(*) e divisão(/ ).

		Exemplo :
		Introduza o número1 : 10
		Introduza o número2 : 5
		Qual a operação(+, -, *ou / ) : /

		Resultado : 2*/

	while (true)
	{	
		float nr1, nr2, output;
		string op;
		cout << "\nIntroduza 1º nr " << endl;
		cin >> nr1;
		cout << "Introduza 2º nr " << endl;
		cin >> nr2;
		cout << "Introduza a operação (+,-,*,/) " << endl;
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