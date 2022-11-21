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
Write("Введите число: ");
string? number = ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    WriteLine($"Ваше число: {number} - Да, это точно палиндром!");
  }
  else WriteLine($"Ваше число: {number} - Нет, это точно не палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else WriteLine($"Введи правильное число");
