#include <cstdio>

int main()
{
    char ISBN[11];
    char VC1;
    char VC2;
    int res;

    scanf("%c-%c%c%c-%c%c%c%c%c-%c", &ISBN[1], &ISBN[2], &ISBN[3], &ISBN[4], &ISBN[5], &ISBN[6], &ISBN[7], &ISBN[8], &ISBN[9], &VC1);

    for(int i = 1; i <= 9; ++i)
    {
        res+=(ISBN[i] - '0') * i;
    }
    VC2 = res%11 + '0' + 1;
    if(VC2 == '0' + 10) VC2='X';
    if(VC2 == VC1) {printf("Right"); return 0;}
    printf("%c-%c%c%c-%c%c%c%c%c-%c", ISBN[1], ISBN[2], ISBN[3], ISBN[4], ISBN[5], ISBN[6], ISBN[7], ISBN[8], ISBN[9], VC2);
    return 0;
}