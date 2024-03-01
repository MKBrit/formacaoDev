#include <iostream>
using namespace std;

int p, cond;
float res;

int main() {
    cout << "Digite o preco normal: ";
    cin >> p;
    cout << "Digite o metodo de pagamento: ";
    cin >> cond;
    switch (cond){
    case 1:
    	res = p-(p*0.10);
    	cout <<"Preço do produto: "<< p << endl << "Condicao de pagamento: " << cond << endl <<"Valor a pagar: "<< res << endl;
    	break;
	case 2:
		res = p-(p*0.15);
		cout <<"Preço do produto: "<< p << endl <<"Condicao de pagamento: " << cond << endl << "Valor a pagar: " << res << endl;
    	break;
    case 3:
    	res = p;
		cout <<"Preço do produto: "<< p << endl;
    	break;
    case 4:
    	res = p+(p*0.10);
		cout <<"Preço do produto: "<< p << endl <<"Condicao de pagamento: "<< cond << endl <<"Valor a pagar: "<< res << endl;
    	break;
	default:
		cout << "Metodo de pagamento invalido";
	}
    return 0;
}