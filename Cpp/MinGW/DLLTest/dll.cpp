#include <iostream>
#define EXPORT __declspec(dllexport)

extern "C"
{
    double EXPORT plusnum(int, int);
    double EXPORT times(int, int); 
}

double plusnum(int num1, int num2)
{
    std::cout << "wadhjskadhjkashdjk";
    return num1 + num2;
}

double times(int num1, int num2)
{
    std::cout << "wadhjaksdkjasd";
    return num1 * num2;
}