using System;
using static System.Console;

Clear();
WriteLine($"Задача 64: \nЗадайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
WriteLine($"M = 1; N = 5. -> 1, 2, 3, 4, 5 \nM = 4; N = 8. -> 4, 6, 7, 8");

Write("Введи N: ");
int N = Convert.ToInt16(ReadLine());
Write("Введи M: ");
int M = Convert.ToInt16(ReadLine());
WriteLine($"N={N}, M={M}");

if (M > N)
    for (int i = N; i <= M; i++)
        Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Write($" {i}");
