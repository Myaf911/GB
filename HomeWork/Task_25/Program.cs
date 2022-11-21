using System;
using static System.Console;

Clear();
WriteLine("Задача 25");
WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число. \nA в натуральную степень B.");
WriteLine("3, 5 - > 243 (3⁵)");
WriteLine("2, 4 - > 16");
WriteLine(" ");
WriteLine("введите число A");
int a = Convert.ToInt32(ReadLine());
WriteLine("введите число B");
int b = Convert.ToInt32(ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
WriteLine("A в степени B равно: " + step);