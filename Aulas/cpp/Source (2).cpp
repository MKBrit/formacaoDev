#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Aluno {
private:
    string nome;
    int idade;
    float notaFinal;
public:
    Aluno() : idade(0), notaFinal(0.0) {}
    void registrarAluno() {
        cout << "Insira o nome do aluno: ";
        cin.ignore();
        getline(cin, nome);
        cout << "Insira a idade do aluno: ";
        cin >> idade;
        cout << "Insira a nota final do aluno: ";
        cin >> notaFinal;
    }
    string getNome() const {
        return nome;
    }
    float getNotaFinal() const {
        return notaFinal;
    }
    void mostrarAluno() const {
        cout << "Nome: " << nome << endl;
        cout << "Idade: " << idade << endl;
        cout << "Nota Final: " << notaFinal << endl;
    }
};
void listarAlunos(const vector<Aluno>& alunos) {
    for (const Aluno& aluno : alunos) {
        aluno.mostrarAluno();
        cout << "-------------------" << endl;
    }
}
float calcularMediaTurma(const vector<Aluno>& alunos) {
    float somaNotas = 0.0;
    for (const Aluno& aluno : alunos) {
        somaNotas += aluno.getNotaFinal();
    }
    return somaNotas / alunos.size();
}
int main() {
    vector<Aluno> alunos;
    int opcao;
    do {
        cout << "Menu:" << endl;
        cout << "1. Registrar aluno" << endl;
        cout << "2. Calcular m�dia da turma" << endl;
        cout << "3. Listar alunos" << endl;
        cout << "4. Pesquisar por aluno" << endl;
        cout << "5. Sair" << endl;
        cout << "Escolha uma op��o: ";
        cin >> opcao;
        switch (opcao) {
        case 1:
        {
            Aluno novoAluno;
            novoAluno.registrarAluno();
            alunos.push_back(novoAluno);
            cout << "Aluno registrado com sucesso!" << endl;
        }
        break;
        case 2:
        {
            float mediaTurma = calcularMediaTurma(alunos);
            cout << "M�dia da turma: " << mediaTurma << endl;
        }
        break;
        case 3:
            listarAlunos(alunos);
            break;
        case 4:
        {
            string nomeAluno;
            cout << "Digite o nome do aluno a ser pesquisado: ";
            cin.ignore();
            getline(cin, nomeAluno);
            bool encontrado = false;
            for (const Aluno& aluno : alunos) {
                if (aluno.getNome() == nomeAluno) {
                    aluno.mostrarAluno();
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) {
                cout << "Aluno n�o encontrado." << endl;
            }
        }
        break;
        case 5:
            cout << "Saindo do programa." << endl;
            break;
        default:
            cout << "Op��o inv�lida. Tente novamente." << endl;
            break;
        }
    } while (opcao != 5);
    return 0;
}