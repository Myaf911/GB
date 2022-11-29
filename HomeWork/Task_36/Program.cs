using System;
using static System.Console;

Clear();
WriteLine("Задача 36");
WriteLine("Задайте одномерный массив, заполненный случайными числами.\nНайдите сумму элементов, стоящих на нечётных позициях.\n[3, 7, 23, 12] -> 19\n[-4, -6, 89, 6] -> 0");

Write("\nРазмер массива? : ");
int length=int.Parse(ReadLine()!);

Write("\nМинимальное значение массива: \n ");
int min=int.Parse(ReadLine()!);

Write("\nМаксимальное значение массива: \n ");
int max=int.Parse(ReadLine()!);

int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindOdd(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random(); 
    int[] result = new int[size];
    WriteLine("\nРандомный массив: ");
    for(int i= 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindOdd(int[] MyArray)
{
    int odd=0;
    for(int i= 1; i< MyArray.Length; i=i+2)
    {
        odd=odd+MyArray[i];
    }
    WriteLine($"\nСумма чисел на нечётных позициях {odd} ");
    WriteLine(" ");

}