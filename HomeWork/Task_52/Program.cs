using System;
using static System.Console;

Clear();
WriteLine("Задача 52");
WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n1 4 7 2\n5 9 2 3\n8 4 2 4\n\nСреднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");

WriteLine($"Введите количество строк");
int n = Convert.ToInt32(ReadLine());
WriteLine($"Введите количество столбцов");
int m = Convert.ToInt32(ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Write(avarage + "; ");
}
WriteLine();
PrintArray(numbers);


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
    }
}