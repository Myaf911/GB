using System;
using static System.Console;

Clear();
WriteLine("Задача 6");
WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
WriteLine("4 - > да");
WriteLine("-3 - > нет");
WriteLine("7 - > нет");
WriteLine(" ");
WriteLine("введите число: ");
string input1 = ReadLine();
int number1 = Convert.ToInt32(input1);

if 
((number1 % 2) ==0 )
{
WriteLine("ДА - число чётное");
}

else
{
WriteLine("НЕТ - число не чётное");
}