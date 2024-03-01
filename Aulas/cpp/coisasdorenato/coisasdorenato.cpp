#include <iostream>
#include <string>
#include <locale> 


using namespace std;

struct Pessoa {
    string nome;
    float altura;
    int idade;
};

void ins_reg(Pessoa pessoas[], int& totalPessoas) {
    if (totalPessoas < 10) {
        cout << "Inserir nome: ";
        cin.ignore();
        getline(cin, pessoas[totalPessoas].nome);
        cout << "Inserir altura: ";
        cin >> pessoas[totalPessoas].altura;
        cout << "Inserir idade: ";
        cin >> pessoas[totalPessoas].idade;
        totalPessoas++;
    }
    else {
        cout << "O limite de 10 pessoas foi atingido." << endl;
    }
}

void list_info(Pessoa pessoas[], int totalPessoas) {
    cout << "Lista de todas as pessoas:\n";
    for (int i = 0; i < totalPessoas; i++) {
        cout << "Nome: " << pessoas[i].nome << ", Idade: " << pessoas[i].idade << ", Altura: " << pessoas[i].altura << " metros" << endl;
    }
}

void list_adults(Pessoa pessoas[], int totalPessoas) {
    cout << "Nomes das pessoas com mais de 18 anos:\n";
    for (int i = 0; i < totalPessoas; i++) {
        if (pessoas[i].idade > 18) {
            cout << pessoas[i].nome << endl;
        }
    }
}

int main() {
    setlocale(LC_ALL, "pt_PT.UTF-8");
    Pessoa pessoas[10];
    int totalPessoas = 0;

    while (true) {
        cout << "\n\nMenu:\n";
        cout << "1. Inserir um registo\n";
        cout << "2. Listar todos os nomes, idades e alturas\n";
        cout << "3. Listar nomes das pessoas com mais de 18 anos\n";
        cout << "4. Sair\n";
        cout << "Escolha uma opção: ";

        int opcao;
        cin >> opcao;
        switch (opcao) {
        case 1:
            ins_reg(pessoas, totalPessoas);
            break;
        case 2:
            list_info(pessoas, totalPessoas);
            break;
        case 3:
            list_adults(pessoas, totalPessoas);
            break;
        case 4:
            cout << "Saindo do programa.\n";
            return 0;
        default:
            cout << "Opção inválida. Tente novamente.\n";
            break;
        }
    }

    return 0;
}
