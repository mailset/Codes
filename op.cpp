#include <iostream>
#include <windows.h>
#include <string>
using namespace std;

int main()
{
    std::cout << "派蒙：\n";
    string lol = "所以说，你们是从世界之外…漂流来的?但在你们想要离开这里，前往下一个世界的时候…却有陌生的神灵，拦在你们的面前?";

    for (int w = 0;w < lol.length(); ++w)
    {
        Sleep(100);
        cout << lol[w];
    }
    cout << endl;

    Sleep(1000);

    std::cout << "……\n";
    Sleep(500);
    std::cout << "陌生的神灵：\n";
    string str = "外来之人，你们的旅途，到此为止。";
    
    for (int i = 0; i < str.length(); ++i)
    {
        Sleep(100);
        cout << str[i];
    }
    cout << endl;

    Sleep(1000);

    std::cout << "荧：\n";
    string pep = "什么人！？";

    for (int n = 0; n < pep.length(); ++n)
    {
        Sleep(100);
        cout << pep[n];
    }
    cout << endl;

    Sleep(1000);

    std::cout << "陌生的神灵：\n";
    string pop = "天理的维系者，在此终结“人之子”的逾越。";

    for (int j = 0; j < pop.length(); ++j)
    {
        Sleep(100);
        cout << pop[j];
    }
    cout << endl;

    Sleep(1000);

    std::cout << "……\n";

    Sleep(1000);

    std::cout << "空:\n";
    string pcp = "妹妹！";

    for (int p = 0; p < pcp.length(); ++p)
    {
        Sleep(100);
        cout << pcp[p];
    }
    cout << endl;

    Sleep(1000);

    std:cout << "空：\n";
    string ppp = "别走!把我妹妹--";

    for(int q = 0; q < ppp.length(); ++q)
    {
        Sleep(100);
        cout << ppp[q];
    }
    cout << endl;
    return 1;
}
