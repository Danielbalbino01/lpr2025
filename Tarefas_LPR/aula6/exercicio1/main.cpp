#include <iostream>
using namespace std;

int main() {
    int numero, reverso = 0;

    cout << "Digite um número inteiro: ";
    cin >> numero;

    while (numero != 0) {
        reverso = reverso * 10 + numero % 10;
        numero /= 10;
    }

    cout << "O número invertido é: " << reverso << endl;

    return 0;
}