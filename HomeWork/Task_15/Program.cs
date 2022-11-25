using System;
using static System.Console;

Clear();
WriteLine("Задача 15");
WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
WriteLine("6 - > да");
WriteLine("1 - > нет");
WriteLine(" ");
Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(ReadLine()); 

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
    WriteLine("да - этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    WriteLine("это вообще не день недели");
  }
  else WriteLine("нет - этот день не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);