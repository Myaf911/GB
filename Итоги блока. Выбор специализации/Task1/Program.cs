using System;
using static System.Console;

Clear();

Write("Введите длину массива строк ");
int n = Convert.ToInt32(ReadLine());

string[] array = new string[n];
string[] arrayResult = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Write("Строка " + (i + 1) + ": ");
    array[i] = ReadLine();
}

WriteLine("\nИсходный массив строк: ");

for (int i = 0; i < array.Length; i++)
{  
    Write($"{array[i]} ");   
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        arrayResult[count] = array[i];
        count++;
    }
}

WriteLine("\nИтоговый массив строк в котором длинна слов меньше или равна 3 символа: ");

for (int i = 0; i < arrayResult.Length; i++)
{  
    Write($"{arrayResult[i]} ");   
}