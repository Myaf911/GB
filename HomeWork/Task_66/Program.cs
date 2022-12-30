using System;
using static System.Console;

Clear();
WriteLine($"Задача 66: \nЗадайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
WriteLine($"M = 1; N = 15 -> 120\nM = 4; N = 8. -> 30");

int InputNumber(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}
int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

Write($"{m}, {n} -> ");
PrintSum(m, n, temp = 0);