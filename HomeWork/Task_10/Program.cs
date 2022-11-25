using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Задача 10");
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число \nи на выходе показывает вторую цифру этого числа.");
Console.WriteLine("456 - > 5");
Console.WriteLine("782 - > 8");
Console.WriteLine("918 - > 1");
Console.WriteLine(" ");
Console.Write("Введи ваше  число: ");

int number = Convert.ToInt32(ReadLine());
string numberString = Convert.ToString(Math.Abs(number));
WriteLine($"вторая цифра твоего числа {number} -> "+numberString[1]);
