// Aluno: nome (string), idade (int) e notas para 3 disciplinas (vetor float).
#include <iostream>
#include <iomanip>
#include <string>
#include <cstring>
using namespace std;


struct Aluno{
    char nome[50];
    int idade;
    float notas[3];
};


//      Formador estou com imensas dificuldades em compreender e utilizar bem os apontadores as class's/struct's, 
//   as chamadas das funções, os return também volta e meia deixam de fazer sentido
//   inclusive ando com dores de cabeça gigantes por causa disto, já nao consigo focar muito tempo no ecrã sem me causar dores



void reg(Aluno alunos[], int& nr_aluno){ 
    if (nr_aluno < 10){
        cout << "Introduza o nome do aluno: " << endl;
        cin.ignore();
        cin.getline(alunos[nr_aluno].nome, sizeof(alunos[nr_aluno].nome));

        cout << "Introduza a idade: " << endl;
        cin >> alunos[nr_aluno].idade;

        for (int i = 0; i < 3; i++){
            cout << "Intoduza a nota da " << i << "º disciplina: " << endl;
            cin >> alunos[nr_aluno].notas[i];
        }  
        nr_aluno++;        
    }
    else{
        cout << "Número máximo de alunos atingido" << endl;
    }
}

void media(){
    
}


void list(){
    
}


void search(){
    
}


//  ######### Main loop ##########

int main(){


int choice, input;
Aluno alunos[10];
int nr_aluno = 0;



while (true){
    cout << "Escolha uma das seguintes opções" << endl;
    cout << "1. Registar novo aluno" << endl;
    cout << "2. Calcular a média" << endl;
    cout << "3. Listar todos os alunos" << endl;
    cout << "4. Pesquisar pelo nome do aluno" << endl;
    cout << "5. Sair" << endl;
    cin >> input;
    if (input > 0 && input < 6){
        choice = input;
        switch (choice){
            case 1:
                reg(alunos, nr_aluno);
                break;
            case 2:
                media();
                break;
            case 3:
                list();
                break;
            case 4:
                search();
                break;
            case 5:
                exit;
        }
    }
}





return 0;
}