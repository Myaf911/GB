using System;
using static System.Console;

Clear();
WriteLine("Задача 47");
WriteLine("Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.\n m = 3, n = 4\n 0,5  7   -2   -0,2\n 1   -3,3  8   -9,9\n 8    7,8 -7,1  9");

WriteLine("\nКоличество строк: ");
int linesVol = Convert.ToInt32(ReadLine());

WriteLine("\nКоличество столбцов: ");
int columnsVol = Convert.ToInt32(ReadLine());

double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("\n[   ");    // Добавил 3 пробела перед скобкой, чтобы придать красоты и нормально читалось все
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + "   "); // Добавил 3 пробела между числами, чтобы придать красоты и нормально читалось все
        }
        Write("]");
        WriteLine(" ");
    }
}
WriteLine(" ");