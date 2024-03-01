#include <iostream>
using namespace std;


int main() {

char resposta= 'S';   
float mercadoria, total, counter;

while(resposta=='S'|| resposta== 's'){
    cout << "Introduza a qtd de mercadoria: " << endl;
    cin >> mercadoria;
    counter++;
    total += mercadoria;
    cout << "Pretende continuar? S ou N: " << endl;
    cin >> resposta;
    
}
float media = total / counter;
cout << "Total = " << total << endl;
cout << "Média = " << media;
return 0;
}