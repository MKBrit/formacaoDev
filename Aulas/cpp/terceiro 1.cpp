#include <iostream>
#include <locale>  
using namespace std;

#define NUM_ALUNOS 10

int menu() {
    int opcao;
    do {
        cout << endl;
        cout << "Alunos" << endl;
        cout << "1 - Inserir um aluno" << endl;
        cout << "2 - Apresentar número do aluno mais novo" << endl;
        cout << "0 - Terminar" << endl;
        cout << "Digite a opção: ";
        cin >> opcao;
    } while (opcao < 0 || opcao > 2);
    return opcao;
}

int inserirUmAluno(int vector[], int n_alunos) {
    if (n_alunos < NUM_ALUNOS) {
        int idade;
        cout << endl << "Introduza a idade do aluno: ";
        cin >> idade;

        if (idade <= 0) {
            cout << "Erro! Idade inválida!" << endl;
            return n_alunos;
        }

        vector[n_alunos] = idade;
        cout << "Introduzido com sucesso!" << endl;
        return n_alunos + 1;
    }
    else {
        cout << "Número máximo de alunos atingido!" << endl;
        return n_alunos;
    }
}

int alunoMaisNovo(const int vector[], int n_alunos) {
    if (n_alunos > 0) {
        int idadeMaisNova = vector[0];
        for (int i = 1; i < n_alunos; i++) {
            if (vector[i] < idadeMaisNova) {
                idadeMaisNova = vector[i];
            }
        }
        return idadeMaisNova;
    }
    else {
        cout << "Nenhum aluno inserido ainda." << endl;
        return -1;
    }
}

int main() {
    setlocale(LC_ALL, "portuguese");

    int n_alunos = 0, opcao;
    int vector[NUM_ALUNOS];

    do {
        opcao = menu();

        if (opcao == 1) {
            n_alunos = inserirUmAluno(vector, n_alunos);
        }
        else if (opcao == 2) {
            int idadeMaisNova = alunoMaisNovo(vector, n_alunos);
            if (idadeMaisNova != -1) {
                cout << "A idade do aluno mais novo é: " << idadeMaisNova << endl;
            }
        }
    } while (opcao != 0);

    return 0;
}