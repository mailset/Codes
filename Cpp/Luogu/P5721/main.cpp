/**
 * @file main.cpp
 * @author mail_set (m_s114514@outlook.com)
 * @brief Luogu P5721
 * Content :P5721.md
 * @version 0.1
 * @date 2022-11-11
 * 
 * @copyright Copyright mail_set (c) 2022
 * 
 */

#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
    int n, whi, res;
    cin >> n;
    whi = n;
    res = 1;
    for(int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= whi; k++)
        {
            if(res < 10) cout << "0";
            cout << res++; 
        }
        whi--;
        cout << endl;
    }
    return 0;
}