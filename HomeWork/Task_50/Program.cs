using System;
using static System.Console;

Clear();
WriteLine("Задача 50");
WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, \nи возвращает значение этого элемента или же указание, что такого элемента нет.\n1 4 7 2\n5 9 2 3\n8 4 2 4\n17 -> такого числа в массиве нет");

WriteLine("\nвведите номер строки");
int n = Convert.ToInt32(ReadLine());
WriteLine("введите номер столбца");
int m = Convert.ToInt32(ReadLine());
int [,] numbers = new int [10,10];  // [10,10] Размер массива который создаем
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    WriteLine("\nТакого элемента нет");
}
else
{
    WriteLine($"\nзначение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
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
            Write(array[i,j] + " ");
        }   
        Write("]");
        WriteLine(""); 
    }
}