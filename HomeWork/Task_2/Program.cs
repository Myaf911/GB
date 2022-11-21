using System;
using static System.Console;

Clear();
WriteLine("Задача 2");
WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
WriteLine("a = 5; b = 7 - > max = 7");
WriteLine("a = 2 b = 10 - > max = 10");
WriteLine("a = -9 b = -3 - > max = -3");
WriteLine(" ");
WriteLine("введите число 1");
string input1 = ReadLine();
int number1 = Convert.ToInt32(input1);

WriteLine("введите число 2");
string input2 = ReadLine();
int number2 = Convert.ToInt32(input2);

if (number1 > number2)
{
WriteLine("Число " + number1 + " больше");
}

if (number1 < number2)
{
WriteLine("Число " + number2 + " больше");
}

if (number1 == number2) 
{
WriteLine("Вы ввели одинаковые числа");
}