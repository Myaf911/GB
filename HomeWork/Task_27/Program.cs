using System;
using static System.Console;

Clear();
WriteLine("Задача 27");
WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
WriteLine("452 - > 11");
WriteLine("82 - > 10");
WriteLine("9012 - > 12");
WriteLine(" ");
WriteLine("Напишиши число: ");
int i = Convert.ToInt32(ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
WriteLine("В твоемм числе, сумма всех цифр равна: " + sum);