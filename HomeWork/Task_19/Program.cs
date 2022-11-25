using System;
using static System.Console;

Clear();
WriteLine("Задача 19");
WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
WriteLine("14212 - > нет");
WriteLine("12821 - > да");
WriteLine("23432 - > да");
WriteLine(" ");
WriteLine("Задача 19");
Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());
string numberString = Convert.ToString(Math.Abs(number));
if (numberString.Length != 5)
{
    WriteLine($"Это не пятизначное число!");
}
else
{
    if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
    {
        WriteLine($"Ваше число: {number} - Да, это точно палиндром!");
    }
    else
    {
        WriteLine($"Ваше число: {number} - Нет, это точно не палиндром.");
    }
}