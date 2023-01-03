#include <iostream>
#define IMPORT __declspec(dllimport)

using namespace std;

extern "C"
{
    double IMPORT plusnum(int, int);
    double IMPORT times(int, int);
}

int main()
{
    cout << "Please enter two numbers: ";
    int num1, num2;
    cin >> num1 >> num2;
    cout << num1 << " plus " << num2 << " equals " << plusnum(num1, num2) << endl;
    cout << num1 << " times " << num2 << " equals " << times(num1, num2) << endl;
    cin.get();
    return 0;
}