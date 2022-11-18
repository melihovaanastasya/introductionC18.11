﻿// Алгоритм Евклида.

/*
int GCD(int a, int b)
{
while (a!=b)
    if (a>b)
        a=a-b;
    else
        b=b-a;
return a;
}
System.Console.WriteLine(GCD(15,20));
*/


int QuickGCD(int a, int b)
{
while (a!=0 && b!=0)
    if (a>b)
        a=a%b;
    else
        b=b%a;
return a+b;
}
System.Console.WriteLine(QuickGCD(15,20));