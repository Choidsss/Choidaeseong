#include <iostream>
#include <string>

using namespace std;

string solution(string str1, string str2);

int main(void) {

    string str1, str2;

    std::cout << "첫번째 변수입력 : ";
    std::cin >> str1;
    std::cout << "두번째 변수입력 : ";
    std::cin >> str2;

    solution(str1, str2);

    return 0;
}

string solution(string str1, string str2) {
    string answer = "";

    for (int i = 0; i < str1.size(); i++)
    {
        answer += str1[i];
        answer += str2[i];
    }
    return answer;
}