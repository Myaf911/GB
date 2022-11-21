using System;
using static System.Console;

Clear();
WriteLine("Задача 8");
WriteLine("Напишите программу, которая на вход принимает число (N), \nа на выходе показывает все чётные числа от 1 до N.");
WriteLine("5 -> 2, 4");
WriteLine("8 -> 2, 4, 6, 8");
WriteLine(" ");
WriteLine("введите число: ");
string input1 = ReadLine();
int number1 = Convert.ToInt32(input1);
int count = 2;
Write("Все чётные числа до вашего числа: ");
while 
(count <= number1)
{
Write(count + " ");
count = count + 2;
}