using System;
using static System.Console;

Clear();
WriteLine("Задача 10");
WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
WriteLine("456 - > 5");
WriteLine("782 - > 8");
WriteLine("918 - > 1");
WriteLine(" ");
Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
WriteLine("вторая цифра этого числа -> "+stringNumber[1]);