using System;
using static System.Console;

Clear();
WriteLine("Задача 13");
WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
WriteLine("645 - > 5");
WriteLine("78 - > третьего числа нет");
WriteLine("32679 - > 6");
WriteLine(" ");
Write("Введи число: ");
int anyNumber = Convert.ToInt32(ReadLine());
string anyNumberText = Convert.ToString(Math.Abs(anyNumber));
if 
(anyNumberText.Length > 2)
{
  WriteLine($"третья цифра твоего числа {anyNumber} -> " + anyNumberText[2]);
}
else 
{
  WriteLine($" {anyNumber} -> тут всего 2 числа, где третье???");
}