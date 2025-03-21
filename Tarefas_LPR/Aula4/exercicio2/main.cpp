#include <iostream>
using namespace std;

int main() {
    int num1, num2;
cout << "digite o primeiro numero: ";
cin >> num1;
cout << "digite o segundo numero: ";
cin >> num2;

    if (num1 % num2 == 0 || num2 % num1 == 0) {
        cout << "Sao Multiplos" << endl;
    } else {
        cout << "Nao sao Multiplos" << endl;
    }

    return 0;
}