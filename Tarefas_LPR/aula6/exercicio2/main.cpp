#include <iostream>
using namespace std;

void mediaNumerosPares() {
    int quant, soma = 0, quantidadePares = 0, numero;

    cout << "Digite a quantidade de números: ";
    cin >> quant;

    for (int i = 0; i < quant; i++) {
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            quantidadePares++;
        }
    }

    if (quantidadePares > 0) {
        double media = (double)soma / quantidadePares;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Não foram digitados números pares." << endl;
    }
}

void somaDigitosQuadrado() {
    int numero, quadrado, soma = 0;

    cout << "Digite um número: ";
    cin >> numero;

    quadrado = numero * numero;

    while (quadrado != 0) {
        soma += quadrado % 10;
        quadrado /= 10;
    }

    cout << "A soma dos dígitos do quadrado é: " << soma << endl;
}

void somaImparesMultiplosDe3() {
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 entre 50 e 500 é: " << soma << endl;
}

int main() {
    int opcao;

    do {
        cout << "\n===== MENU =====" << endl;
        cout << "1 - Média dos números pares" << endl;
        cout << "2 - Soma dos dígitos do quadrado" << endl;
        cout << "3 - Soma dos ímpares múltiplos de 3" << endl;
        cout << "0 - Sair" << endl;
        cout << "Escolha uma opção: ";
        cin >> opcao;

        if (opcao == 1) {
            mediaNumerosPares();
        } else if (opcao == 2) {
            somaDigitosQuadrado();
        } else if (opcao == 3) {
            somaImparesMultiplosDe3();
        } else if (opcao != 0) {
            cout << "Opção inválida!" << endl;
        }
    } while (opcao != 0);

    cout << "Saindo do programa..." << endl;

    return 0;
}
