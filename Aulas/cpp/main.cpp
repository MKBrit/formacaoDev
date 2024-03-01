#include <iostream>
#include <locale>
using namespace std;

int main() {
    setlocale(LC_ALL, "pt_PT");
    
/*      Crie os programas seguintes e submeta no Teams os sources(.cpp).

        Exercício 1: 
        Faça um programa em C++ para calcular a média de três valores inteiros
        Apenas um exemplo do funcionamento :
            Valores lidos :
        10
        15
        13
        Resultado(média) : 12, 7
*/

    float a = 10, b = 15, c = 13;
    float media = (a + b + c) / 3;
    cout << "A média dos valores é de " << media << endl;

/*      Exercício 2 : 
        Faça um programa em C++ que leia o tempo de duração de um evento numa fábrica, expresso em segundos e mostre - o expresso em horas, minutos e os restantes segundos.
        Apenas um exemplo do funcionamento :
        Tempo duração evento(segundos) : 7503
        Resultado : 2 Horas, 5 Minutos e 3 Segundos
*/
    int segundos = 7503;
    int horas = segundos / 3600;
    int minutos = (segundos % 3600) / 60; 
    int segundos_restantes = segundos % 60;
    cout << segundos << " segundos em horas são " << horas << " horas e " << minutos << " minutos e " << segundos_restantes << " segundos" << endl;
}