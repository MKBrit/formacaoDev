#include <iostream>
using namespace std;

int main(){    
    int num1, num2;
    int* ptr1 = &num1;
    int* ptr2 = &num2;

    while (true){
        cout << "Introduza 1º nr\n";
        if (!(cin >> num1) && num1 <= 0){
            break;
        }
        cout << "Introduza 2º nr\n";
        if (!(cin >> num2) && num2 <= 0){
            break;    
        }
        cout << "Soma dos nr = " << *ptr1 + *ptr2 <<endl;
        cout << "Subtracção dos nr = " << *ptr1 - *ptr2 <<endl;
        cout << "Multiplicação dos nr = " << *ptr1 * *ptr2 <<endl;
        cout << "Divisão dos nr = " << *ptr1 / *ptr2 <<endl;

    break;
    }
} 