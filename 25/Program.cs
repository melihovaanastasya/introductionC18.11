﻿// 25. Вывести на экран кубы чисел от 1 до N

int N=Convert.ToInt32(Console.ReadLine());
for (int i=1;i<=N;i++) 
    System.Console.Write($"{Math.Pow(i,3)} ");