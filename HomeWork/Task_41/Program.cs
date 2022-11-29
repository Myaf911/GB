using System;
using static System.Console;

Clear();
WriteLine("Задача 41");
WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
WriteLine("0, 7, 8, -2, -2 -> 2");
WriteLine("1, -7, 567, 89, 223 -> 3");

Write("\nВведите элементы (через пробел) : ");
int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
WriteLine($"\nКол-во элементов > 0 = {count} ");
WriteLine(" ");


// Второй вариант, более короткий но рабочий
//
// Write("\nВведите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// WriteLine($"\nКол-во элементов > 0 = {count}");
