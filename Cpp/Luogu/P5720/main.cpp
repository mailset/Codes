/**
 * @file main.cpp
 * @author mail_set (m_s114514@outlook.com)
 * @brief Luogu P5720
 * Content :P5720.md
 * @version 0.1
 * @date 2022-11-11
 * 
 * @copyright Copyright (c) 2022
 * 
 */

#include <iostream>

using namespace std;

int main()
{
    int a;
    int res;
    cin >> a;
    for(int n = 1;;)
    {
        if(a == 1) break;
        a /= 2;
        res++;
    }
    cout << res + 1;
    return 0;
}