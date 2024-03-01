#include <iostream>
using namespace std;

int n1, n2, pairCounter, entryCounter, positionWinner, biggestDiff;
int difference = n1-n2;
int main() {
    
      while(n1 =! 0 && n2 != 0)
      entryCounter++;
        cout << "Digite uma série de 2 números naturais começando pelo maior primeiro, e termine com 0 0: " << endl;
        cin >> n1 >> n2;
        
        if(n1%2==0 && n2%2==0)
        pairCounter++;
        
        if(difference>biggestDiff)
        biggestDiff= difference;
        positionWinner = entryCounter;
            
    return 0;
}