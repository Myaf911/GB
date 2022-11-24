using System;
using static System.Console;

Console.Clear();
Console.WriteLine("Задача 10");
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число \nи на выходе показывает вторую цифру этого числа.");
Console.WriteLine("456 - > 5");
Console.WriteLine("782 - > 8");
Console.WriteLine("918 - > 1");
Console.WriteLine(" ");
Console.Write("Введи трёхзначное число (Без МИНУСА!): ");
int number = Convert.ToInt32(ReadLine());

void CheckingNumberNull (int number) 
{
  if (number > 0) 
  {
    Console.WriteLine("Отлично, минуса нету!'");
    Console.WriteLine(" ");
  }
  else if (number < 0) 
  {
    Console.WriteLine("\nХА! Но это не точно! Убери минус и повтори запрос!\n");
  }
}
CheckingNumberNull (number);

string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
Console.WriteLine(" ");


