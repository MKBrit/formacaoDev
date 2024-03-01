#include <iostream>
#include <string>
#include <locale>
using namespace std;

bool checkVogais(char c) {
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
}

string vogais(const string& input) {
    string result;
    for (char c : input) {
        if (checkVogais(c)) {
            result += c;
        }
    }
    return result;
}

int main() {
    setlocale(LC_ALL, "portuguese");

    string string1, string2;
    cout << "Digite a primeira frase: ";
    getline(cin, string1);

    cout << "Digite a segunda frase: ";
    getline(cin, string2);

    string string3 = vogais(string1 + string2);

    cout << "Frase com vogais das duas frases: " << string3 << endl;

    return 0;
}