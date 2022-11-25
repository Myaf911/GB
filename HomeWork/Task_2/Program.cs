using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Задача 2");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
Console.WriteLine("a = 5; b = 7 - > max = 7");
Console.WriteLine("a = 2 b = 10 - > max = 10");
Console.WriteLine("a = -9 b = -3 - > max = -3");
Console.WriteLine(" ");
Console.WriteLine("введите число 1");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("введите число 2");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

if (number1 > number2)
{
Console.WriteLine("Число " + number1 + " больше");
}

if (number1 < number2)
{
Console.WriteLine("Число " + number2 + " больше");
}

if (number1 == number2) 
{
Console.WriteLine("Вы ввели одинаковые числа");
}