#include <iostream>
#include <cstring>
using namespace std;

struct Alunos {
    int nr_alunos;
    string nome;
    float nota_alunos;
    Alunos *prox;    
};

void inserir(Alunos* &cabecalho, string nome, int nr_alunos, float nota_alunos){
    Alunos *novoAlunos;
    novoAlunos = new Alunos;
    (*novoAlunos).nome = nome;
    (*novoAlunos).nr_alunos = nr_alunos;
    (*novoAlunos).nota_alunos = nota_alunos;
    (*novoAlunos).prox = cabecalho;

    cabecalho = novoAlunos;
}

void listar(Alunos* cabecalho){
    Alunos* valor_atual;
    while (valor_atual != nullptr){
        cout << "Número aluno" << valor_atual->nr_alunos << endl;
        cout << "Nome aluno" << valor_atual->nr_alunos<< endl;
        cout << "Nota aluno" << valor_atual->nota_alunos<< endl;
        valor_atual = valor_atual->prox;
    }
    
}

float media(Alunos* cabecalho){
    float soma = 0;
    int totalAlunos = 0;
    Alunos* valor_atual;
    while(valor_atual != nullptr){
        soma += valor_atual->nota_alunos;
        totalAlunos++;
        valor_atual = valor_atual->prox;
    }
    return soma / totalAlunos;
}



int main() {
    int input, nr;
    string nome;
    float nota;
    Alunos* cabecalho;


    while (input != 4){
        cout << "Selecione uma operação" << endl;
        cout << "1 - Inserir alunos" << endl;
        cout << "2 - Listar alunos" << endl;
        cout << "3 - Calcular a média de alunos" << endl;
        cout << "4 - Sair" << endl;
        cin >> input;
        if (input < 1 || input > 4) {
            cout << "Erro" << endl;
        } 
        else {
            switch (input) {
                case 1:
                    cout << "Opção 1 selecionada: Inserir alunos" << endl;
                    cout << "Introduza o nome" << endl;
                    cin >> nome;
                    cout << "Introduza o número" << endl;
                    cin >> nr;
                    cout << "Introduza a nota" << endl;
                    cin >> nota;
                    inserir(cabecalho, nome, nr, nota);
                    cout << "Sucesso" << endl;
                    break;
                case 2:
                    cout << "Opção 2 selecionada: Listar alunos" << endl;
                    listar(cabecalho);
                    break;
                case 3:
                    cout << "Opção 3 selecionada: Calcular a média de alunos" << endl;
                    float medias = media(cabecalho);
                    cout << medias << endl;
                    break;
                case 4:
                    cout << "Saíndo";
                    break;
            }
        }
    }
    return 0;
}