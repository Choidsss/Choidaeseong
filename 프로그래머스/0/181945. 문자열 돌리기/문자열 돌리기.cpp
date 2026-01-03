#include <iostream>
#include <string>

using namespace std;

int main(void) {
    string str;

    cin >> str;

    for (int i = 0; i < str.length();i++) {
        std::cout << str[i] << std::endl;
    }
    return 0;
}