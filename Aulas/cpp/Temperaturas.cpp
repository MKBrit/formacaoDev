#include <iostream>
#include <string>
using namespace std;


int main() {

int counter, userCounter, temp, starCount;
string cidade;

cout << "Introduza quantas cidades pretende ler: " << endl;
cin >> userCounter;

    while (userCounter != 0){
    userCounter --;
    counter ++;
    cout << counter << "ª Cidade : ";
    cin >> cidade;
    cout << "Temperatura : ";
    cin >> temp;
    starCount = temp/2;
    cout << "A temperatura para a cidade: " << cidade << " é de " << temp << " ";
        while(starCount!=0){
        starCount--;
        cout << "*";
        }
    cout << endl;
    cout << endl;
    }
return 0;
}