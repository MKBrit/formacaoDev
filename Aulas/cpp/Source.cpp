#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <stdexcept>
#include <locale> 
#include <cctype>
#include <fstream>
#include <cstdlib>

using namespace std;

class Contacto {
private:
    int numero;
    string nome, email, tlm;

public:
    Contacto(int vNumero, string vNome, string vEmail, string vTlm) {   
        numero = vNumero;
        nome = vNome;
        email = vEmail;
        tlm = vTlm;
    }

    // Getters
    int getNr() {
        return numero;}
    string getNome() {
        return nome;}
    string getEmail() {
        return email;}
    string getTlm() {
        return tlm;}


    // Setters
    int setNr(int nNr) {
        numero = nNr;}
    string setNome(string nNome) {
        nome = nNome;}
    string setEmail(string nEmail) {
        email = nEmail;}
    string setTlm(string nTlm) {
        tlm = nTlm;}
};




class Agenda {
private:
    vector<Contacto> contactos;

public:

    void addCont() {
        int numero;                             // ##### DUVIDA ##### provavelmente ser� aqui que uso os setters que pediu mas nao tou a conseguir
        string nome, email, tlm;

        cout << "N�mero: ";
        cin >> numero;
        cin.ignore();
        for (Contacto contacto : contactos) {   // Aqui crio um novo objecto tempor�rio para percorrer o vector de contactos enquanto houver "contacto" dispon�vel
            if (contacto.getNr() == numero) {   // Se o nr que vamos buscar pelo metodo getNr() deste contacto da itera��o corrente for igual ao numero que o user introduziu, ent�o 
                cout << "Erro  - N�mero j� existe" << endl; // print Erro e termina o metodo addCont(), que por sua volta ao menu principal
                return;
            }
        }
        cout << "Nome: ";
        getline(cin, nome);

        cout << "Email: ";
        getline(cin, email);

        cout << "Telem�vel: ";
        getline(cin, tlm);

        Contacto novoContacto(numero, nome, email, tlm);
        contactos.push_back(novoContacto);
        cout << "Sucesso" << endl;
    }

    void listCont() {
        cout << "Lista de contactos\n\n\t(Posi��o | Nome | Email | Tlm)" << endl;
        for (int i = 0; i < contactos.size(); i++) {    // Vamos come�ar um loop numa variavel int i temporaria, a come�ar no zero. Enquanto este i que inicialmente tem 0, for inferior ao tamanho total do vector contactos. No final da itera��o incrementa 1 ao valor de i
            Contacto contacto = contactos[i];           // Novo contacto tempor�rio para receber o conteudo da posi��o i (inicialmente 0) do vector contactos, at� � �ltima posi��o
            cout << " | " << contacto.getNr() << " | " << contacto.getNome() << " | " << contacto.getEmail() << " | " << contacto.getTlm() << endl; // Numa linha imprimo " | ", o nr presente nesta itera��o," | " o nome presente............etc
        }
        cout << endl;
    }

    void saveCont() {
        ofstream file("contactos.txt"); // Criamos ou truncamos com o ficheiro j� criado para escrita no txt
        if (file.is_open()) {   // se o file(ficheiro txt declarado acima) estiver aberto que verificamos com o metodo is_open() ent�o
            file << "(Posi��o | Nome | Email | Tlm)" << endl;
            for (Contacto contacto : contactos) {   // A mesma coisa do metodo anterior
                file << contacto.getNr() << " | " << contacto.getNome() << " | " << contacto.getEmail() << " | " << contacto.getTlm() << endl;
            }
            file.close();
            cout << "Sucesso a gravar contactos" << endl;
        }
        else {  
            cout << "Erro a gravar contactos" << endl;
        }
    }

    void loadCont() {
        ifstream file("contactos.txt");             // Abrimos o ficheiro para leitura e declaramos como "file" 
        if (file.is_open()) {                       // Se/If o "file" estiver aberto (m�todo "is_open()") ent�o 
            string line;                            // Declaramos uma linha/line como variavel string para guardar cada linha do "file" 1 a 1
            getline(file, line);                    // Ignoramos o cabe�alho (id|Nome....etc
            if (!getline(file, line)) {             // Tenta ler a primeira linha, caso nao exista, significa que o ficheiro est� vazio
                cout << "Erro a carregar contactos (n�o existem contactos)" << endl;
                file.close();
                return;                             // sa�mos do metodo de volta ao menu principal
            }
            while (getline(file, line)) {           // Enquanto/while o m�todo "getline"
                int numero;                         // Declaramos as 4 vari�veis ##### DUVIDA #####
                string nome, email, tlm;

                // Aqui apoiei-me de pesquisa para guardar o txt com os separadores " | " e ler de l� os dados direitos sem usar as ";" como mostrou na aula

                istringstream iss(line);                    // Isto torna o conte�do da variav�l string "line", ou seja cada linha, numa string stream, que me permite percorrer o conteudo de cada linha quase como passo a passo
                iss >> numero;                              // Depois a variavel numero aqui vai receber o que est� � espera, um int, logo grava o numero do contacto sem muita dificuldade visto ser o unico int presente na string
                iss.ignore(3);                              // Isto vai ignorar os proximos 3 caracteres do resultado que retiramos ou seja (" | ") para a proxima variavel ficar correta 
                getline(iss, nome, '|');                    // Agora vamos retirar o pr�ximo valor, o nome, at� ao caract�r "|". A este ponto da string stream, j� passamos pelo nr e pelo 1� separador, pelo nome e estamos logo a seguir ao "|", ou seja temos um espa�o
                nome = nome.substr(0, nome.find_last_not_of(" \t") + 1);    // Aqui usamos 2 metodos, para limpar os caracteres extra do nome, criamos uma substring (substr) que 1�Arg come�a no index 0, onde come�a o nome; 2�Arg comprimento, que � igual ao tamanho at� ao ultimo caracter que n�o seja um " " ou "\t", (espa�o e tab) + 1(esse ultimo caracter tambem faz parte da string que queremos guardar) 
                getline(iss, email, '|');
                email = email.substr(1, email.find_last_not_of(" \t") + 1); // Mesma coisa, mas come�amos no index 1 evitando o espa�o que desta vez nao foi logo cortado da mesma forma que com o .ignore()
                getline(iss, tlm);
                tlm = tlm.substr(1, tlm.find_last_not_of(" \t") + 1);       // Mesma coisa, mas come�amos no index 1 evitando o espa�o que desta vez nao foi logo cortado da mesma forma que com o .ignore()
                

                Contacto novoContacto(numero, nome, email, tlm);            // Criamos um novo contacto temporario e "enfiamo-lo" na ultima posi��o disponivel no vector contactos
                contactos.push_back(novoContacto);
            }
            file.close();   // Acabando a leitura, fechamos o ficheiro txt e informamos na consola que se abriu e leu o ficheiro com sucesso
            cout << "Contactos carregados com sucesso" << endl;
        }
        else {      // Caso o ficheiro nao exista pq nunca foi adicionado um contacto, em principio por ser a 1� utiliza��o
            cout << "Bem-vindo!\nComece por adicionar o seu primeiro contacto!" << endl;
        }       // Tentei, mas existem ocasioes em que ele cria o cabe�alho e a partir da� ja nao aparece este mensagem mas outra mesmo que nunca tenha adicionado contacto
    }
    // Aqui tive a ideia de usar um comando powershell e o comando de imprimir pelo notepad que estava no pdf, mas nao funcionou bem como esperado, nao sei se � por nao ter impressora, mas estranho � pq quando tento imprimir manualmente pelo notepad, aparece o wizard do windows da impressora 
    void toPdf() {
        saveCont();
        cout << "Aguarde por favor..." << endl;
        string file = "contactos.txt";
        string cmd = "powershell Start-Process -FilePath \"" + file + "\" -Verb Print";
        system(cmd.c_str());
        system("cls");
    }

    void print() { // Nao tenho impressora para testar, mas pelo que tive a ver, seria isto, mas est�-me a gravar em pdf outra vez
        saveCont();
        cout << "Aguarde por favor..." << endl;
        string file = "contactos.txt";
        string cmd = "notepad /p \"" + file + "\"";
        system(cmd.c_str());
        system("cls");
    }
};



int main() {
    setlocale(LC_ALL, "Portuguese");
    Agenda agenda;
    int opcao;
    agenda.loadCont();


    while (true) {  // Main loop, � suposto ser um ciclo infinito, pelo menos at� o utilizador sair do programa pelas op��es disponiveis
        cout << "::: Menu Agenda :::\n\n";
        cout << "1. Adicionar Contactos\n";
        cout << "2. Listar Contactos\n";
        cout << "3. Gerar PDF\n";
        cout << "4. Imprimir Agenda\n";
        cout << "0. Sair\n";
        cout << "Escolha uma op��o: ";
        cin >> opcao;
        system("cls");

        switch (opcao) {    // Aqui dependendo da op��o que o utilizador escolher, vai selecionar um "case" espec�fico, que por sua vez vai ativar o metodo associado ao que o utilizador pretende
            case 1: {
                agenda.addCont();
                break;
            }
            case 2: {
                agenda.listCont();
                break;
            }
            case 3: {
                agenda.toPdf();
                break;
            }
            case 4: {
                agenda.print();
                break;
            }
            case 0: {
                agenda.saveCont();
                return 0;
            }
            default: {
                cout << "Op��o inv�lida. Tenta outra vez." << endl;
            }
        }
    }
    return 0;
}