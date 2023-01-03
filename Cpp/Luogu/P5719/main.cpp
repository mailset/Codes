/**
 * @file main.cpp
 * @author mail_set(m_s114514@outlook.com)
 * @brief Luogu Problem 1055
 * Content : P1055.md
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
    int n, k;
    cin >> n >> k;
    double res1 = 0;
    int count1 = 0;
    double res2 = 0;
    int count2 = 0;
    for (int j = 1; j <= n; j++)
    {
        if(j % k == 0) 
        {
            res1 += j; 
            count1++;
        }
        else
        {
            res2 += j; 
            count2++;
        }
    }
    res1 /= count1;
    res2 /= count2;
    printf("%.1lf %.1lf", res1, res2);
    return 0;
}
