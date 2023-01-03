#include <iostream>
#include <string>

int main()
{
	using namespace std;
	string hezdl;
	while (1)
	{
		cin >> hezdl;
		if (hezdl == "我帮你吧") cout << "喝，长大了！" << endl;
		if (hezdl == "break") break;
	}
	return 0;
}