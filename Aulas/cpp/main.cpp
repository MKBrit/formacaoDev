#include <iostream>
#include <locale>
using namespace std;

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

    float a = 10, b = 15, c = 13;
    float media = (a + b + c) / 3;
    cout << "A m�dia dos valores � de " << media << endl;

/*      Exerc�cio 2 : 
        Fa�a um programa em C++ que leia o tempo de dura��o de um evento numa f�brica, expresso em segundos e mostre - o expresso em horas, minutos e os restantes segundos.
        Apenas um exemplo do funcionamento :
        Tempo dura��o evento(segundos) : 7503
        Resultado : 2 Horas, 5 Minutos e 3 Segundos
*/
    int segundos = 7503;
    int horas = segundos / 3600;
    int minutos = (segundos % 3600) / 60; 
    int segundos_restantes = segundos % 60;
    cout << segundos << " segundos em horas s�o " << horas << " horas e " << minutos << " minutos e " << segundos_restantes << " segundos" << endl;
}