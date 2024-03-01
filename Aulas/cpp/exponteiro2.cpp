#include <iostream>
using namespace std;

int main(){
    int* ptr1 = new int;
    int* ptr2 = new int;

    while (true){
        cout << "Introduza 1º nr\n";
        if (!(cin >> *ptr1) && *ptr1 <= 0){
            break;
        }
        cout << "Introduza 2º nr\n";
        if (!(cin >> *ptr2) && *ptr2 <= 0){
            break;    
        }
        cout << "Soma dos nr = " << *ptr1 + *ptr2 <<endl;
        cout << "Subtracção dos nr = " << *ptr1 - *ptr2 <<endl;
        cout << "Multiplicação dos nr = " << *ptr1 * *ptr2 <<endl;
        cout << "Divisão dos nr = " << *ptr1 / *ptr2 <<endl;

    break;
    }
} 