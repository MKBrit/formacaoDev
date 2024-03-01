#include <iostream>
#include <locale>
using namespace std;
#include <cmath>
#define PI 3.1415

int main() {
    setlocale(LC_ALL, "pt_PT");
    
/*      Crie os programas seguintes e submeta no Teams os sources(.cpp).

        Exerc�cio 1: 
        Fa�a um programa em C++ para calcular a m�dia de tr�s valores inteiros
        Apenas um exemplo do funcionamento :
            Valores lidos :
        10
        15
        13
        Resultado(m�dia) : 12, 7
*/
  /*  float a = 10, b = 15, c = 13;
    float media = (a + b + c) / 3;
    cout << "A m�dia dos valores � de " << media << endl;*/

/*      Exerc�cio 2 : 
        Fa�a um programa em C++ que leia o tempo de dura��o de um evento numa f�brica, expresso em segundos e mostre - o expresso em horas, minutos e os restantes segundos.
        Apenas um exemplo do funcionamento :
        Tempo dura��o evento(segundos) : 7503
        Resultado : 2 Horas, 5 Minutos e 3 Segundos
*/
   /* int segundos = 7503;
    int horas = segundos / 3600;
    int minutos = (segundos % 3600) / 60; 
    int segundos_restantes = segundos % 60;
    cout << segundos << " segundos em horas s�o " << horas << " horas e " << minutos << " minutos e " << segundos_restantes << " segundos" << endl;*/

/*Desenvolver uma programa em C++ para calcular o per�metro e a �rea de um circulo.
    F�rmulas:
        Per�metro = 2 * PI * Raio
        �rea = PI * Raio ^ 2
*/
    /*float raioInput;  

    cout << "Introduza o raio para calcular o per�metro e a �rea de um c�rculo em metros " << endl;
    cin >> raioInput;

    float perimetro = 2 * PI * raioInput;
    float area = PI * (raioInput * raioInput);

    cout << "O per�metro do c�rculo � de " << perimetro << ", e a �rea � de " << area << "m�." << endl;
    return 0;*/

/*  A Kikas tem um cofre com muitas moedas, e deseja saber quantos euros conseguiu poupar.
    Fa�a um algoritmo para ler a quantidade de cada tipo de moeda, e imprimir o valor total guardado, em euros.
    Considere que existem moedas de 1, 5, 10, 20 e 50 c�ntimos, e ainda moedas de 1 euro.
    N�o havendo moedas de um tipo, a respetiva quantidade � zero.*/
   /* int qtd1Cent, qtd5Cent, qtd10Cent, qtd20Cent, qtd50Cent, qtd1Euro;
    cout << "Introduza quantas moedas de 1 cent tem " << endl;
    cin >> qtd1Cent;
    cout << "Introduza quantas moedas de 5 cent tem " << endl;
    cin >> qtd5Cent;
    cout << "Introduza quantas moedas de 10 cent tem " << endl;
    cin >> qtd10Cent;
    cout << "Introduza quantas moedas de 20 cent tem " << endl;
    cin >> qtd20Cent;
    cout << "Introduza quantas moedas de 50 cent tem " << endl;
    cin >> qtd50Cent;
    cout << "Introduza quantas moedas de 1 euro tem " << endl;
    cin >> qtd1Euro;    
    float total = (qtd1Cent * 0.01) + (qtd5Cent * 0.05) + (qtd10Cent * 0.1) + (qtd20Cent * 0.2) + (qtd50Cent * 0.50) + (qtd1Euro * 1);
    cout << "A Kikas tem um total de " << total << " euros." << endl;*/

/*      O custo ao consumidor de um carro novo � a soma do custo de f�brica com a percentagem do distribuidor e dos impostos(aplicados ao custo de f�brica).
        Supondo que a percentagem do distribuidor � de 28 % e os impostos de 45 %, 
    escrever um programa em C++ que leia o custo de f�brica de um carro e escreva o custo ao consumidor.
            Exemplo:
        Qual o valor do carro na f�brica ?
            Percentagem_distribuidor = preco_fabrica * 0.28
            Impostos = preco_fabrica * 0.45
            Valor total = preco_fabrica + percentagem_distribuidor + impostos 
*/
   /* float custoFabrica;
    cout << "Introduza o valor do custo de f�brica: " << endl;
    cin >> custoFabrica;
    float comissao = custoFabrica * 0.28;
    float impostos = custoFabrica * 0.45;
    float total = custoFabrica + comissao + impostos;
    cout << "O valor final do Carro � de " << total << endl;*/

/*      Tr�s amigos, Ana, Andr� e Rita decidiram dividir a conta de um bar.
        Fa�a um algoritmo para ler o valor total da conta e imprimir quanto cada um deve pagar.
        No entanto deve ter a seguinte particularidade, Ana e Andr� n�o devem pagar c�ntimos.
            Exemplo:
        Para uma conta de 101, 53�.
        Os valores a pagar s�o os seguinte : 33, 00� para a Ana, 33, 00� para o Andr� e 35, 53� para a Rita.*/

    float total = 101.53;
    int ana = total / 3;
    int andre = total / 3;
    float rita = total - (ana + andre);

    cout << "A Ana vai pagar " << ana << " euros, o Andr� vai pagar " << andre << " euros e a Rita paga o resto da conta " << rita << " euros." << endl;

    return 0;
}