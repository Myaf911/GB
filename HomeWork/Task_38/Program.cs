using System;
using static System.Console;

Clear();
WriteLine("Задача 38");
WriteLine("Задайте массив вещественных чисел. Найдите разницу между \nмаксимальным и минимальным элементов массива.");
WriteLine("[3 7 22 2 78] -> 76");
WriteLine(" ");

Write("Какой размер массива: ");
int length = int.Parse(ReadLine()!);

Write("Минимальное значение массива?: ");
int min = int.Parse(ReadLine()!);

Write("Максимальное значение массива?: ");
int max = int.Parse(ReadLine()!);

int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]"); 
FindDifference(Array, max, min);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result= new int[size];
    for(int i= 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    return result;
}

void FindDifference(int[] MyArray, int minVal, int maxVal)
{
    for(int i = 0; i < MyArray.Length; i++)
    {
        if(MyArray[i] < minVal)
        {
            minVal=MyArray[i];
        }
        if(MyArray[i] > maxVal)
        {
            maxVal=MyArray[i];
        }
    }
    WriteLine ($" Разница -> {maxVal-minVal} ");
}
