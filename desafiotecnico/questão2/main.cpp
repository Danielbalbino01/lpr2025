#include <iostream>
#include <algorithm> 
using namespace std;
int main() {
    int altura1,altura2,altura3;
cout << "digite a altura do mosca: ";
cin >> altura1;
cout << "digite a altura do gatti: ";
cin >> altura2;
cout << "digite a altura da ana leticia: ";
cin >> altura3;
int alturas[] = {altura1, altura2, altura3};
    std::sort(alturas, alturas + 3);
    std::cout << "A altura do professor Gatti é: " << alturas[1] << std::endl;
    return 0;


}
